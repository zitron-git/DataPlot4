using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.IO.Ports;
using ZedGraph;
using System.Runtime.InteropServices;

namespace DataPlot3
{
    public partial class Form1 : Form
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct AccelDataPacket
        {
            public byte id;
            public uint t;
            public short X;
            public short Y;
            public short Z;
        }
        private static Thread _RSIThread;

        UdpClient UDPServer;
        IPEndPoint ACCELEP = null;

        int receiveport = 0;

        int NoOfCurves, Samples;
        int[,] colourList = {{128,0,0},{0,128,0},{0,0,128},{0,128,128},{128,128,0},{255,0,0},{0,255,0},
                            {0,0,255},{255,255,0},{255,0,255},{0,255,255}};

        private AccelDataPacket APacket;

        private byte[] buffer = new byte[255];
        private byte rx_len;
        private byte rx_array_inx;
        private int structSize;
        private byte id = 255;
        private uint oldT, deltaT;

        private bool Logging;
        private string logfilename;
        private int linesLogged;

        private volatile bool _shouldStop, _streaming;

        List<AccelDataPacket> Loglist = new List<AccelDataPacket>();
        List<RollingPointPairList> Data = new List<RollingPointPairList>();
        List<IPointListEdit> IPoints = new List<IPointListEdit>();

        //these are copied from the intarwebs, converts struct to byte array
        private static byte[] StructureToByteArray(object obj)
        {
            int len = Marshal.SizeOf(obj);
            byte[] arr = new byte[len];
            IntPtr ptr = Marshal.AllocHGlobal(len);
            Marshal.StructureToPtr(obj, ptr, true);
            Marshal.Copy(ptr, arr, 0, len);
            Marshal.FreeHGlobal(ptr);
            return arr;
        }

        private static object ByteArrayToStructure(byte[] bytearray, object obj)
        {
            int len = Marshal.SizeOf(obj);

            IntPtr i = Marshal.AllocHGlobal(len);

            Marshal.Copy(bytearray, 0, i, len);

            obj = Marshal.PtrToStructure(i, obj.GetType());

            Marshal.FreeHGlobal(i);

            return obj;
        }

        static string ByteToHexBitFiddle(byte[] bytes)
        {
            char[] c = new char[bytes.Length * 2];
            int b;
            for (int i = 0; i < bytes.Length; i++)
            {
                b = bytes[i] >> 4;
                c[i * 2] = (char)(55 + b + (((b - 10) >> 31) & -7));
                b = bytes[i] & 0xF;
                c[i * 2 + 1] = (char)(55 + b + (((b - 10) >> 31) & -7));
            }
            return new string(c);
        }



        private void GetPortList()
        {
            String[] realports = SerialPort.GetPortNames();

            COMPortComboBox.Items.Clear();

            if (realports == null || realports.Length == 0)
            {
                RawTextBox.AppendText("No COM ports found\n");
            }
            else
            {
                foreach (string name in realports)
                {
                    COMPortComboBox.Items.Add(name);
                }
            }
        }

        public Form1()
        {
            InitializeComponent();

            Logging = false;
            _streaming = false;
            _shouldStop = true;

            COMPortStatusLight.Border.ChromeWidth = 2;
            COMPortStatusLight.Border.RimWidth = 2;
            UDPStatusLight.Border.ChromeWidth = 2;
            UDPStatusLight.Border.RimWidth = 2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set the titles and axis labels
            // MAA
            ZedGraphControl1.GraphPane.Title.Text = "Time History";
            ZedGraphControl1.GraphPane.XAxis.Title.Text = "Samples";
            ZedGraphControl1.GraphPane.YAxis.Title.Text = "";

            ZedGraphControl1.GraphPane.XAxis.Scale.MaxGrace = 0;

            ZedGraphControl1.GraphPane.YAxis.MajorGrid.IsVisible = true;

            ZedGraphControl1.GraphPane.XAxis.MajorGrid.IsVisible = true;

            ZedGraphControl1.GraphPane.Legend.Position = ZedGraph.LegendPos.Right;

            GetPortList();
        }

        private void COMConnectBtn_Click(object sender, EventArgs e)
        {
            COMConnectButton.Enabled = false;

            COMPortStatusLight.Value = 3;

            if (Port.IsOpen)
            {
                _streaming = false;

                Port.Write("o");

                Thread.Sleep(Port.ReadTimeout); //Wait for reading threads to finish

                new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    Port.Close();
                }).Start();



                COMPortStatusLight.Value = -1;
                COMConnectButton.Text = "Connect";

                StopStreamButton.Enabled = false;
                StartStreamButton.Enabled = false;
                timer1.Enabled = false;
            }
            else
            {
                try
                {
                    Port.PortName = COMPortComboBox.Text;
                    Port.BaudRate = int.Parse(COMBaudComboBox.Text);
                    Port.Open();
                }
                catch
                {
                    COMPortStatusLight.Value = -1;
                    MessageBox.Show("Could not open " + COMPortComboBox.Text);
                }

                if (Port.IsOpen)
                {
                    COMPortStatusLight.Value = 1;
                    COMConnectButton.Text = "Disconnect";

                    Data.Clear();
                    IPoints.Clear();
                    deleteCurves();
                    initCurves();

                    timer1.Enabled = true;

                    StopStreamButton.Enabled = true;
                    StartStreamButton.Enabled = true;
                }
            }

            COMConnectButton.Enabled = true;
        }

        private void initCurves()
        {
            Samples = int.Parse(SampleTextBox.Text);
            NoOfCurves = (int)NoOfDataNumericUpDown.Value;


            for (int j = 0; j < NoOfCurves; j++)
            {
                RollingPointPairList tempppl = new RollingPointPairList(Samples);
                /*
                for (double x = 0; x < Samples; x++)
                {
                    tempppl.Add(x, 0);
                }
                */
                Data.Add(tempppl);
                ZedGraphControl1.GraphPane.AddCurve("Data " + j.ToString(), Data[j],
                    Color.FromArgb(colourList[j, 0], colourList[j, 1], colourList[j, 2]), SymbolType.None);

                LineItem curve = ZedGraphControl1.GraphPane.CurveList[j] as LineItem;

                IPoints.Add(curve.Points as IPointListEdit);
            }


        }

        private void deleteCurves()
        {
            ZedGraphControl1.GraphPane.CurveList.Clear();
        }

        private bool processCOM()
        {
            byte calc_CS;

            if (rx_len == 0)
            {
                while (Port.ReadByte() != 0xBE)
                {
                    if (Port.BytesToRead == 0)
                        return false;
                }

                if (Port.ReadByte() == 0xEF)
                {
                    rx_len = (byte)Port.ReadByte();
                    id = (byte)Port.ReadByte();
                    rx_array_inx = 1;

                    switch (id)
                    {
                        case 0:
                            structSize = Marshal.SizeOf(APacket);
                            break;
                    }

                    //make sure the binary structs on both Arduino and plugin are the same size.
                    if (rx_len != structSize || rx_len == 0)
                    {
                        rx_len = 0;
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                while (Port.BytesToRead > 0 && rx_array_inx <= rx_len)
                {
                    buffer[rx_array_inx++] = (byte)Port.ReadByte();
                }
                buffer[0] = id;

                if (rx_len == (rx_array_inx - 1))
                {
                    //seem to have got whole message
                    //last uint8_t is CS
                    calc_CS = rx_len;
                    for (int i = 0; i < rx_len; i++)
                    {
                        calc_CS ^= buffer[i];
                    }

                    if (calc_CS == buffer[rx_array_inx - 1])
                    {//CS good
                        rx_len = 0;
                        rx_array_inx = 1;
                        return true;
                    }
                    else
                    {
                        //failed checksum, need to clear this out anyway
                        rx_len = 0;
                        rx_array_inx = 1;
                        return false;
                    }
                }
            }

            return false;
        }

        private void ProcessUDP()
        {
            this.Invoke((MethodInvoker)delegate { RawTextBox.AppendText("Thread Started\n"); });

            try
            {
                UDPServer = new UdpClient(receiveport);
            }
            catch (Exception e)
            {
                this.Invoke((MethodInvoker)delegate { RawTextBox.AppendText(e.ToString() + "\n"); });
                timer1.Stop();
                return;
            }

            UDPServer.Client.ReceiveTimeout = 1000;

            while (!_shouldStop)
            {
                try
                {
                    //receive is blocking
                    byte[] data = UDPServer.Receive(ref ACCELEP);

                    if (data == null || data.Length == 0)
                    {
                        this.Invoke((MethodInvoker)delegate { RawTextBox.AppendText("\nReceive thread timed out\n"); });
                    }
                    else
                    {
                        //this.Invoke((MethodInvoker)delegate { RawTextBox.AppendText(ByteToHexBitFiddle(data) + "\n"); });

                        byte len, id;

                        len = data[2];
                        id = data[3];

                        byte[] temp = new byte[len];

                        switch (id)
                        {
                            case 0: //accel packet
                                Array.Copy(data, 3, temp, 0, len);
                                APacket = (AccelDataPacket)ByteArrayToStructure(temp, APacket);
                                //this.Invoke((MethodInvoker)delegate { RawTextBox.AppendText(ByteToHexBitFiddle(temp) + "\n"); });
                                this.Invoke(new EventHandler(ProcessData));
                                break;
                        }

                        //this.Invoke((MethodInvoker)delegate { RawTextBox.AppendText(string.Format("{0} {1}\n", len, id)); });
                    }
                }
                catch
                {
                    //this.Invoke((MethodInvoker)delegate { DebugTextBox.AppendText("\nReceive thread timed out\n"); });
                }
            }

            timer1.Stop();
            UDPServer.Close();
            this.Invoke((MethodInvoker)delegate { RawTextBox.AppendText("Thread Closed\n"); });
        }

        private void ReadError(object sender, EventArgs e)
        {
            RawTextBox.AppendText("Read Line Error\n");
        }

        private void ProcessData(object sender, EventArgs e)
        {
            PointPair temp = new PointPair();

            updateCurve(IPoints[0], (double)APacket.t / 1000000, (double)APacket.X);
            updateCurve(IPoints[1], (double)APacket.t / 1000000, (double)APacket.Y);
            temp = updateCurve(IPoints[2], (double)APacket.t / 1000000, (double)APacket.Z);

            ZedGraphControl1.GraphPane.XAxis.Scale.Min = temp.X;
            ZedGraphControl1.GraphPane.XAxis.Scale.Max = temp.Y;
            //RawTextBox.AppendText(APacket.t.ToString() + '\n');

            deltaT = APacket.t - oldT;
            oldT = APacket.t;

            if (deltaT > 2500)
                RawTextBox.AppendText(string.Format("Packet lost at T = {0,5} delta T = {1,5}\n", APacket.t, deltaT));

            if (Logging)
            {
                Loglist.Add(APacket);
                linesLogged++;
            }
        }

        private PointPair updateCurve(IPointListEdit list, double t, double v)
        {
            PointPair temp = new PointPair();

            list.Add(t, v);

            temp.X = list[0].X;
            temp.Y = t;

            return temp;
            /*
            for (int j = ZedGraphControl1.GraphPane.CurveList[k].NPts - 1; j > 0; j--)
            {
                ZedGraphControl1.GraphPane.CurveList[k].Points[j].Y = ZedGraphControl1.GraphPane.CurveList[k].Points[j - 1].Y;
            }

            //RawTextBox.AppendText(temp.ToString() + "-" + k.ToString() + ", ");
            ZedGraphControl1.GraphPane.CurveList[k].Points[0].X = 0;
            ZedGraphControl1.GraphPane.CurveList[k].Points[0].Y = v;
             */
        }

        private void SerialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (Port.IsOpen && _streaming)
            {
                while (Port.BytesToRead > 5)
                {
                    if (processCOM())
                    {
                        switch (id)
                        {
                            case 0:
                                APacket = (AccelDataPacket)ByteArrayToStructure(buffer, APacket);
                                this.Invoke(new EventHandler(ProcessData));
                                break;
                            default:
                                this.BeginInvoke(new EventHandler(ReadError));
                                break;
                        }
                    }
                    if (!Port.IsOpen || !_streaming)
                    {
                        break;
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ZedGraphControl1.AxisChange();
            ZedGraphControl1.Invalidate();
            LinesLoggedLabel.Text = string.Format("Logged = {0,7}", linesLogged);
            DeltaTLabel.Text = string.Format("Delta T = {0,7}", deltaT);

            if (!_shouldStop)
            {
                if (ACCELEP == null)
                    IPLabel.Text = "No IP";
                else
                    IPLabel.Text = ACCELEP.Address.ToString();
            }
        }

        private void COMRefreshButton_Click(object sender, EventArgs e)
        {
            GetPortList();
        }

        private void StartStreamButton_Click(object sender, EventArgs e)
        {
            _streaming = true;
            Port.Write("s");
        }

        private void StopStreamButton_Click(object sender, EventArgs e)
        {
            _streaming = false;
            Port.Write("o");
        }

        private void FileButton_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK) // Test result.
            {
                logfilename = saveFileDialog.FileName;

                fileNameTextBox.Text = Path.GetFileName(logfilename);
                fileNameLabel.Text = Path.GetDirectoryName(saveFileDialog.FileName);

                RawTextBox.AppendText("Log File: " + logfilename + "\n"); // <-- For debugging use.
            }
            else
            {
                RawTextBox.AppendText(result.ToString() + "\n"); // <-- For debugging use.
            }
        }

        private void LogStartButton_Click(object sender, EventArgs e)
        {
            logfilename = fileNameLabel.Text + "\\" + fileNameTextBox.Text;
            Logging = true;
            linesLogged = 0;

            Loglist.Clear();
        }

        private void LogStopButton_Click(object sender, EventArgs e)
        {
            Logging = false;
        }

        private void LogSaveButton_Click(object sender, EventArgs e)
        {
            if (Loglist.Count == 0)
            {
                RawTextBox.AppendText("Log list empty\n"); // <-- For debugging use.
            }
            else if (string.IsNullOrEmpty(fileNameTextBox.Text) || string.IsNullOrEmpty(logfilename) || logfilename.IndexOfAny(Path.GetInvalidFileNameChars()) < 0)
            {
                RawTextBox.AppendText("File name invalid\n"); // <-- For debugging use.
            }
            else if (File.Exists(logfilename))
            {
                RawTextBox.AppendText(string.Format("File {0} already exists\n", logfilename)); // <-- For debugging use.
            }
            else
            {
                RawTextBox.AppendText("Log File: " + logfilename + "\n"); // <-- For debugging use.
                RawTextBox.AppendText("Saving log... ");

                //RawTextBox.AppendText(string.Format("{0}, {1}, {2}, {3}\n", k.t, k.X, k.Y, k.Z));

                using (StreamWriter outputFile = new StreamWriter(logfilename))
                {
                    foreach (AccelDataPacket k in Loglist)
                    {
                        outputFile.WriteLine(string.Format("{0}, {1}, {2}, {3}", k.t, k.X, k.Y, k.Z));
                    }
                }

                RawTextBox.AppendText("done\n");
            }
        }

        private void StartUDPButton_Click(object sender, EventArgs e)
        {
            if (_shouldStop == false)
            {
                _shouldStop = true;
                StartUDPButton.Text = "Start";
                timer1.Stop();
                UDPStatusLight.Value = -1;
            }
            else
            {
                _shouldStop = false;
                receiveport = int.Parse(UDPortBox.Text);

                Data.Clear();
                IPoints.Clear();
                deleteCurves();
                initCurves();

                _RSIThread = new Thread(ProcessUDP);
                _RSIThread.IsBackground = true;
                _RSIThread.Start();
                StartUDPButton.Text = "Stop";
                timer1.Start();
                UDPStatusLight.Value = 1;
            }
        }
    }
}
