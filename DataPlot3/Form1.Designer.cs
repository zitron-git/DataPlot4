namespace DataPlot3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ComPortGroupBox = new System.Windows.Forms.GroupBox();
            this.StopStreamButton = new System.Windows.Forms.Button();
            this.StartStreamButton = new System.Windows.Forms.Button();
            this.COMRefreshButton = new System.Windows.Forms.Button();
            this.COMPortStatusLight = new PolyMonControls.StatusLight();
            this.COMPortComboBox = new System.Windows.Forms.ComboBox();
            this.COMBaudComboBox = new System.Windows.Forms.ComboBox();
            this.COMConnectButton = new System.Windows.Forms.Button();
            this.Port = new System.IO.Ports.SerialPort(this.components);
            this.RawTextBox = new System.Windows.Forms.TextBox();
            this.ZedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.OptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.NoOfDataNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SampleTextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LinesLoggedLabel = new System.Windows.Forms.Label();
            this.DeltaTLabel = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.FileButton = new System.Windows.Forms.Button();
            this.LogStartButton = new System.Windows.Forms.Button();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.LogStopButton = new System.Windows.Forms.Button();
            this.LogSaveButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.IPLabel = new System.Windows.Forms.Label();
            this.UDPortBox = new System.Windows.Forms.TextBox();
            this.UDPStatusLight = new PolyMonControls.StatusLight();
            this.StartUDPButton = new System.Windows.Forms.Button();
            this.ComPortGroupBox.SuspendLayout();
            this.OptionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfDataNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComPortGroupBox
            // 
            this.ComPortGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ComPortGroupBox.Controls.Add(this.StopStreamButton);
            this.ComPortGroupBox.Controls.Add(this.StartStreamButton);
            this.ComPortGroupBox.Controls.Add(this.COMRefreshButton);
            this.ComPortGroupBox.Controls.Add(this.COMPortStatusLight);
            this.ComPortGroupBox.Controls.Add(this.COMPortComboBox);
            this.ComPortGroupBox.Controls.Add(this.COMBaudComboBox);
            this.ComPortGroupBox.Controls.Add(this.COMConnectButton);
            this.ComPortGroupBox.Location = new System.Drawing.Point(715, 451);
            this.ComPortGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.ComPortGroupBox.Name = "ComPortGroupBox";
            this.ComPortGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.ComPortGroupBox.Size = new System.Drawing.Size(124, 133);
            this.ComPortGroupBox.TabIndex = 0;
            this.ComPortGroupBox.TabStop = false;
            this.ComPortGroupBox.Text = "COM Port";
            // 
            // StopStreamButton
            // 
            this.StopStreamButton.BackColor = System.Drawing.Color.LightCoral;
            this.StopStreamButton.Enabled = false;
            this.StopStreamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopStreamButton.Location = new System.Drawing.Point(64, 96);
            this.StopStreamButton.Margin = new System.Windows.Forms.Padding(2);
            this.StopStreamButton.Name = "StopStreamButton";
            this.StopStreamButton.Size = new System.Drawing.Size(55, 23);
            this.StopStreamButton.TabIndex = 6;
            this.StopStreamButton.Text = "Stop";
            this.StopStreamButton.UseVisualStyleBackColor = false;
            this.StopStreamButton.Click += new System.EventHandler(this.StopStreamButton_Click);
            // 
            // StartStreamButton
            // 
            this.StartStreamButton.BackColor = System.Drawing.Color.LimeGreen;
            this.StartStreamButton.Enabled = false;
            this.StartStreamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartStreamButton.Location = new System.Drawing.Point(4, 96);
            this.StartStreamButton.Margin = new System.Windows.Forms.Padding(2);
            this.StartStreamButton.Name = "StartStreamButton";
            this.StartStreamButton.Size = new System.Drawing.Size(55, 23);
            this.StartStreamButton.TabIndex = 5;
            this.StartStreamButton.Text = "Start";
            this.StartStreamButton.UseVisualStyleBackColor = false;
            this.StartStreamButton.Click += new System.EventHandler(this.StartStreamButton_Click);
            // 
            // COMRefreshButton
            // 
            this.COMRefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.COMRefreshButton.Location = new System.Drawing.Point(64, 42);
            this.COMRefreshButton.Margin = new System.Windows.Forms.Padding(2);
            this.COMRefreshButton.Name = "COMRefreshButton";
            this.COMRefreshButton.Size = new System.Drawing.Size(55, 21);
            this.COMRefreshButton.TabIndex = 4;
            this.COMRefreshButton.Text = "Refresh";
            this.COMRefreshButton.UseVisualStyleBackColor = true;
            this.COMRefreshButton.Click += new System.EventHandler(this.COMRefreshButton_Click);
            // 
            // COMPortStatusLight
            // 
            this.COMPortStatusLight.BackgroundImage = System.Drawing.Color.Empty;
            this.COMPortStatusLight.BackgroundImageLayout = System.Drawing.Color.Empty;
            this.COMPortStatusLight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.COMPortStatusLight.Location = new System.Drawing.Point(4, 70);
            this.COMPortStatusLight.Margin = new System.Windows.Forms.Padding(2);
            this.COMPortStatusLight.Name = "COMPortStatusLight";
            this.COMPortStatusLight.OffColor = System.Drawing.Color.Black;
            this.COMPortStatusLight.Size = new System.Drawing.Size(18, 22);
            this.COMPortStatusLight.TabIndex = 3;
            this.COMPortStatusLight.Text = "COMPortStatusLight";
            // 
            // COMPortComboBox
            // 
            this.COMPortComboBox.FormattingEnabled = true;
            this.COMPortComboBox.Location = new System.Drawing.Point(5, 42);
            this.COMPortComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.COMPortComboBox.Name = "COMPortComboBox";
            this.COMPortComboBox.Size = new System.Drawing.Size(54, 21);
            this.COMPortComboBox.TabIndex = 2;
            // 
            // COMBaudComboBox
            // 
            this.COMBaudComboBox.FormattingEnabled = true;
            this.COMBaudComboBox.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "14400",
            "28800",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600",
            "1382400"});
            this.COMBaudComboBox.Location = new System.Drawing.Point(4, 17);
            this.COMBaudComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.COMBaudComboBox.Name = "COMBaudComboBox";
            this.COMBaudComboBox.Size = new System.Drawing.Size(115, 21);
            this.COMBaudComboBox.TabIndex = 1;
            this.COMBaudComboBox.Text = "9600";
            // 
            // COMConnectButton
            // 
            this.COMConnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.COMConnectButton.Location = new System.Drawing.Point(32, 70);
            this.COMConnectButton.Margin = new System.Windows.Forms.Padding(2);
            this.COMConnectButton.Name = "COMConnectButton";
            this.COMConnectButton.Size = new System.Drawing.Size(87, 22);
            this.COMConnectButton.TabIndex = 0;
            this.COMConnectButton.Text = "Connect";
            this.COMConnectButton.UseVisualStyleBackColor = true;
            this.COMConnectButton.Click += new System.EventHandler(this.COMConnectBtn_Click);
            // 
            // Port
            // 
            this.Port.ReadBufferSize = 1024;
            this.Port.ReadTimeout = 2000;
            this.Port.ReceivedBytesThreshold = 5;
            this.Port.WriteBufferSize = 1024;
            this.Port.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort_DataReceived);
            // 
            // RawTextBox
            // 
            this.RawTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RawTextBox.Location = new System.Drawing.Point(9, 451);
            this.RawTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.RawTextBox.MaxLength = 1000;
            this.RawTextBox.Multiline = true;
            this.RawTextBox.Name = "RawTextBox";
            this.RawTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.RawTextBox.Size = new System.Drawing.Size(701, 133);
            this.RawTextBox.TabIndex = 1;
            // 
            // ZedGraphControl1
            // 
            this.ZedGraphControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ZedGraphControl1.AutoSize = true;
            this.ZedGraphControl1.BackColor = System.Drawing.SystemColors.InfoText;
            this.ZedGraphControl1.IsAutoScrollRange = true;
            this.ZedGraphControl1.Location = new System.Drawing.Point(9, 11);
            this.ZedGraphControl1.Name = "ZedGraphControl1";
            this.ZedGraphControl1.ScrollGrace = 0D;
            this.ZedGraphControl1.ScrollMaxX = 0D;
            this.ZedGraphControl1.ScrollMaxY = 0D;
            this.ZedGraphControl1.ScrollMaxY2 = 0D;
            this.ZedGraphControl1.ScrollMinX = 0D;
            this.ZedGraphControl1.ScrollMinY = 0D;
            this.ZedGraphControl1.ScrollMinY2 = 0D;
            this.ZedGraphControl1.Size = new System.Drawing.Size(701, 435);
            this.ZedGraphControl1.TabIndex = 2;
            // 
            // OptionsGroupBox
            // 
            this.OptionsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OptionsGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.OptionsGroupBox.Controls.Add(this.NoOfDataNumericUpDown);
            this.OptionsGroupBox.Controls.Add(this.label2);
            this.OptionsGroupBox.Controls.Add(this.label1);
            this.OptionsGroupBox.Controls.Add(this.SampleTextBox);
            this.OptionsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OptionsGroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.OptionsGroupBox.Location = new System.Drawing.Point(715, 11);
            this.OptionsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.OptionsGroupBox.Name = "OptionsGroupBox";
            this.OptionsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.OptionsGroupBox.Size = new System.Drawing.Size(124, 98);
            this.OptionsGroupBox.TabIndex = 3;
            this.OptionsGroupBox.TabStop = false;
            this.OptionsGroupBox.Text = "Options";
            // 
            // NoOfDataNumericUpDown
            // 
            this.NoOfDataNumericUpDown.Location = new System.Drawing.Point(4, 30);
            this.NoOfDataNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.NoOfDataNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NoOfDataNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NoOfDataNumericUpDown.Name = "NoOfDataNumericUpDown";
            this.NoOfDataNumericUpDown.Size = new System.Drawing.Size(116, 20);
            this.NoOfDataNumericUpDown.TabIndex = 5;
            this.NoOfDataNumericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Samples";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "No. of data sets";
            // 
            // SampleTextBox
            // 
            this.SampleTextBox.Location = new System.Drawing.Point(4, 69);
            this.SampleTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SampleTextBox.Name = "SampleTextBox";
            this.SampleTextBox.Size = new System.Drawing.Size(116, 20);
            this.SampleTextBox.TabIndex = 1;
            this.SampleTextBox.Text = "2000";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.LinesLoggedLabel);
            this.groupBox1.Controls.Add(this.DeltaTLabel);
            this.groupBox1.Location = new System.Drawing.Point(715, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 73);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // LinesLoggedLabel
            // 
            this.LinesLoggedLabel.Font = new System.Drawing.Font("SimHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinesLoggedLabel.Location = new System.Drawing.Point(4, 39);
            this.LinesLoggedLabel.Name = "LinesLoggedLabel";
            this.LinesLoggedLabel.Size = new System.Drawing.Size(116, 23);
            this.LinesLoggedLabel.TabIndex = 1;
            this.LinesLoggedLabel.Text = "Logged = 0";
            this.LinesLoggedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DeltaTLabel
            // 
            this.DeltaTLabel.Font = new System.Drawing.Font("SimHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeltaTLabel.Location = new System.Drawing.Point(4, 16);
            this.DeltaTLabel.Name = "DeltaTLabel";
            this.DeltaTLabel.Size = new System.Drawing.Size(116, 23);
            this.DeltaTLabel.TabIndex = 0;
            this.DeltaTLabel.Text = "Delta T = 0";
            this.DeltaTLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Title = "Save Log";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.fileNameLabel);
            this.groupBox2.Controls.Add(this.FileButton);
            this.groupBox2.Controls.Add(this.LogStartButton);
            this.groupBox2.Controls.Add(this.fileNameTextBox);
            this.groupBox2.Controls.Add(this.LogStopButton);
            this.groupBox2.Controls.Add(this.LogSaveButton);
            this.groupBox2.Location = new System.Drawing.Point(715, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(124, 145);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Logging";
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileNameLabel.Location = new System.Drawing.Point(4, 16);
            this.fileNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(116, 42);
            this.fileNameLabel.TabIndex = 17;
            this.fileNameLabel.Text = "File:";
            // 
            // FileButton
            // 
            this.FileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FileButton.Location = new System.Drawing.Point(4, 87);
            this.FileButton.Name = "FileButton";
            this.FileButton.Size = new System.Drawing.Size(55, 23);
            this.FileButton.TabIndex = 16;
            this.FileButton.Text = "File";
            this.FileButton.UseVisualStyleBackColor = true;
            this.FileButton.Click += new System.EventHandler(this.FileButton_Click);
            // 
            // LogStartButton
            // 
            this.LogStartButton.BackColor = System.Drawing.Color.LimeGreen;
            this.LogStartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogStartButton.Location = new System.Drawing.Point(4, 116);
            this.LogStartButton.Name = "LogStartButton";
            this.LogStartButton.Size = new System.Drawing.Size(55, 23);
            this.LogStartButton.TabIndex = 15;
            this.LogStartButton.Text = "Start";
            this.LogStartButton.UseVisualStyleBackColor = false;
            this.LogStartButton.Click += new System.EventHandler(this.LogStartButton_Click);
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(4, 61);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(116, 20);
            this.fileNameTextBox.TabIndex = 14;
            // 
            // LogStopButton
            // 
            this.LogStopButton.BackColor = System.Drawing.Color.LightCoral;
            this.LogStopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogStopButton.Location = new System.Drawing.Point(65, 116);
            this.LogStopButton.Name = "LogStopButton";
            this.LogStopButton.Size = new System.Drawing.Size(55, 23);
            this.LogStopButton.TabIndex = 13;
            this.LogStopButton.Text = "Stop";
            this.LogStopButton.UseVisualStyleBackColor = false;
            this.LogStopButton.Click += new System.EventHandler(this.LogStopButton_Click);
            // 
            // LogSaveButton
            // 
            this.LogSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogSaveButton.Location = new System.Drawing.Point(65, 87);
            this.LogSaveButton.Name = "LogSaveButton";
            this.LogSaveButton.Size = new System.Drawing.Size(55, 23);
            this.LogSaveButton.TabIndex = 12;
            this.LogSaveButton.Text = "Save";
            this.LogSaveButton.UseVisualStyleBackColor = true;
            this.LogSaveButton.Click += new System.EventHandler(this.LogSaveButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.IPLabel);
            this.groupBox3.Controls.Add(this.UDPortBox);
            this.groupBox3.Controls.Add(this.UDPStatusLight);
            this.groupBox3.Controls.Add(this.StartUDPButton);
            this.groupBox3.Location = new System.Drawing.Point(716, 344);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(124, 102);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "UDP";
            // 
            // IPLabel
            // 
            this.IPLabel.Font = new System.Drawing.Font("SimHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPLabel.Location = new System.Drawing.Point(6, 19);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(112, 20);
            this.IPLabel.TabIndex = 16;
            this.IPLabel.Text = "000.000.000.000";
            this.IPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UDPortBox
            // 
            this.UDPortBox.Location = new System.Drawing.Point(64, 43);
            this.UDPortBox.Name = "UDPortBox";
            this.UDPortBox.Size = new System.Drawing.Size(54, 20);
            this.UDPortBox.TabIndex = 15;
            this.UDPortBox.Text = "13700";
            // 
            // UDPStatusLight
            // 
            this.UDPStatusLight.BackgroundImage = System.Drawing.Color.Empty;
            this.UDPStatusLight.BackgroundImageLayout = System.Drawing.Color.Empty;
            this.UDPStatusLight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UDPStatusLight.Location = new System.Drawing.Point(4, 66);
            this.UDPStatusLight.Margin = new System.Windows.Forms.Padding(2);
            this.UDPStatusLight.Name = "UDPStatusLight";
            this.UDPStatusLight.OffColor = System.Drawing.Color.Black;
            this.UDPStatusLight.Size = new System.Drawing.Size(18, 22);
            this.UDPStatusLight.TabIndex = 10;
            // 
            // StartUDPButton
            // 
            this.StartUDPButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartUDPButton.Location = new System.Drawing.Point(64, 67);
            this.StartUDPButton.Margin = new System.Windows.Forms.Padding(2);
            this.StartUDPButton.Name = "StartUDPButton";
            this.StartUDPButton.Size = new System.Drawing.Size(54, 23);
            this.StartUDPButton.TabIndex = 7;
            this.StartUDPButton.Text = "Start";
            this.StartUDPButton.UseVisualStyleBackColor = true;
            this.StartUDPButton.Click += new System.EventHandler(this.StartUDPButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 593);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OptionsGroupBox);
            this.Controls.Add(this.ZedGraphControl1);
            this.Controls.Add(this.RawTextBox);
            this.Controls.Add(this.ComPortGroupBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(864, 631);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "DataPlot V4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ComPortGroupBox.ResumeLayout(false);
            this.OptionsGroupBox.ResumeLayout(false);
            this.OptionsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfDataNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ComPortGroupBox;
        private System.Windows.Forms.ComboBox COMPortComboBox;
        private System.Windows.Forms.ComboBox COMBaudComboBox;
        private System.Windows.Forms.Button COMConnectButton;
        private PolyMonControls.StatusLight COMPortStatusLight;
        private System.IO.Ports.SerialPort Port;
        private System.Windows.Forms.TextBox RawTextBox;
        private ZedGraph.ZedGraphControl ZedGraphControl1;
        private System.Windows.Forms.GroupBox OptionsGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SampleTextBox;
        private System.Windows.Forms.NumericUpDown NoOfDataNumericUpDown;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button COMRefreshButton;
        private System.Windows.Forms.Button StopStreamButton;
        private System.Windows.Forms.Button StartStreamButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label DeltaTLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label LinesLoggedLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Button FileButton;
        private System.Windows.Forms.Button LogStartButton;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Button LogStopButton;
        private System.Windows.Forms.Button LogSaveButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private PolyMonControls.StatusLight UDPStatusLight;
        private System.Windows.Forms.Button StartUDPButton;
        private System.Windows.Forms.TextBox UDPortBox;
        private System.Windows.Forms.Label IPLabel;
    }
}

