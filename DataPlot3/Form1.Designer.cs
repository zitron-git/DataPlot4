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
            this.DeltaTLabel = new System.Windows.Forms.Label();
            this.ComPortGroupBox.SuspendLayout();
            this.OptionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfDataNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.ComPortGroupBox.Location = new System.Drawing.Point(715, 378);
            this.ComPortGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.ComPortGroupBox.Name = "ComPortGroupBox";
            this.ComPortGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.ComPortGroupBox.Size = new System.Drawing.Size(124, 205);
            this.ComPortGroupBox.TabIndex = 0;
            this.ComPortGroupBox.TabStop = false;
            this.ComPortGroupBox.Text = "COM Port";
            // 
            // StopStreamButton
            // 
            this.StopStreamButton.Enabled = false;
            this.StopStreamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopStreamButton.Location = new System.Drawing.Point(52, 179);
            this.StopStreamButton.Margin = new System.Windows.Forms.Padding(2);
            this.StopStreamButton.Name = "StopStreamButton";
            this.StopStreamButton.Size = new System.Drawing.Size(68, 22);
            this.StopStreamButton.TabIndex = 6;
            this.StopStreamButton.Text = "Stop";
            this.StopStreamButton.UseVisualStyleBackColor = true;
            this.StopStreamButton.Click += new System.EventHandler(this.StopStreamButton_Click);
            // 
            // StartStreamButton
            // 
            this.StartStreamButton.Enabled = false;
            this.StartStreamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartStreamButton.Location = new System.Drawing.Point(52, 153);
            this.StartStreamButton.Margin = new System.Windows.Forms.Padding(2);
            this.StartStreamButton.Name = "StartStreamButton";
            this.StartStreamButton.Size = new System.Drawing.Size(68, 22);
            this.StartStreamButton.TabIndex = 5;
            this.StartStreamButton.Text = "Start";
            this.StartStreamButton.UseVisualStyleBackColor = true;
            this.StartStreamButton.Click += new System.EventHandler(this.StartStreamButton_Click);
            // 
            // COMRefreshButton
            // 
            this.COMRefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.COMRefreshButton.Location = new System.Drawing.Point(33, 93);
            this.COMRefreshButton.Margin = new System.Windows.Forms.Padding(2);
            this.COMRefreshButton.Name = "COMRefreshButton";
            this.COMRefreshButton.Size = new System.Drawing.Size(87, 22);
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
            this.COMPortStatusLight.Location = new System.Drawing.Point(10, 67);
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
            this.COMPortComboBox.Location = new System.Drawing.Point(4, 41);
            this.COMPortComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.COMPortComboBox.Name = "COMPortComboBox";
            this.COMPortComboBox.Size = new System.Drawing.Size(115, 21);
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
            this.COMConnectButton.Location = new System.Drawing.Point(33, 67);
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
            this.Port.ReceivedBytesThreshold = 2;
            this.Port.WriteBufferSize = 1024;
            this.Port.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort_DataReceived);
            // 
            // RawTextBox
            // 
            this.RawTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RawTextBox.Location = new System.Drawing.Point(9, 378);
            this.RawTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.RawTextBox.MaxLength = 1000;
            this.RawTextBox.Multiline = true;
            this.RawTextBox.Name = "RawTextBox";
            this.RawTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.RawTextBox.Size = new System.Drawing.Size(701, 206);
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
            this.ZedGraphControl1.Size = new System.Drawing.Size(701, 362);
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
            this.OptionsGroupBox.Size = new System.Drawing.Size(124, 199);
            this.OptionsGroupBox.TabIndex = 3;
            this.OptionsGroupBox.TabStop = false;
            this.OptionsGroupBox.Text = "Options";
            // 
            // NoOfDataNumericUpDown
            // 
            this.NoOfDataNumericUpDown.Location = new System.Drawing.Point(4, 43);
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
            this.label2.Location = new System.Drawing.Point(4, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Samples";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "No. of data sets";
            // 
            // SampleTextBox
            // 
            this.SampleTextBox.Location = new System.Drawing.Point(4, 82);
            this.SampleTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SampleTextBox.Name = "SampleTextBox";
            this.SampleTextBox.Size = new System.Drawing.Size(116, 20);
            this.SampleTextBox.TabIndex = 1;
            this.SampleTextBox.Text = "4000";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.DeltaTLabel);
            this.groupBox1.Location = new System.Drawing.Point(715, 215);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 158);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // DeltaTLabel
            // 
            this.DeltaTLabel.Location = new System.Drawing.Point(4, 16);
            this.DeltaTLabel.Name = "DeltaTLabel";
            this.DeltaTLabel.Size = new System.Drawing.Size(109, 23);
            this.DeltaTLabel.TabIndex = 0;
            this.DeltaTLabel.Text = "Delta T =      0";
            this.DeltaTLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 593);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OptionsGroupBox);
            this.Controls.Add(this.ZedGraphControl1);
            this.Controls.Add(this.RawTextBox);
            this.Controls.Add(this.ComPortGroupBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "DataPlot V4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ComPortGroupBox.ResumeLayout(false);
            this.OptionsGroupBox.ResumeLayout(false);
            this.OptionsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfDataNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
    }
}

