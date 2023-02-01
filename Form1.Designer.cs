
namespace Controller
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtBx_conStatus = new System.Windows.Forms.TextBox();
            this.Graph_Temperature = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.Graph_Temp = new NationalInstruments.UI.WaveformPlot();
            this.xAxis4 = new NationalInstruments.UI.XAxis();
            this.yAxis4 = new NationalInstruments.UI.YAxis();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.TxtBx_Status = new System.Windows.Forms.TextBox();
            this.Graph_ControlSignalU = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.Graph_U = new NationalInstruments.UI.WaveformPlot();
            this.xAxis1 = new NationalInstruments.UI.XAxis();
            this.yAxis1 = new NationalInstruments.UI.YAxis();
            this.TxtBx_ActualTemp = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Gb_Temp = new System.Windows.Forms.GroupBox();
            this.sb_TempSP = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CB_RealProc = new System.Windows.Forms.ComboBox();
            this.CB_Mode = new System.Windows.Forms.ComboBox();
            this.sb_ManModeVolt = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SB_TimeConstant = new System.Windows.Forms.NumericUpDown();
            this.SB_KCV = new System.Windows.Forms.NumericUpDown();
            this.SB_t_Delay = new System.Windows.Forms.NumericUpDown();
            this.SB_T_Env = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sb_Td = new System.Windows.Forms.NumericUpDown();
            this.sb_Kp = new System.Windows.Forms.NumericUpDown();
            this.sb_Ti = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Graph_Temperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Graph_ControlSignalU)).BeginInit();
            this.Gb_Temp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sb_TempSP)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sb_ManModeVolt)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SB_TimeConstant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SB_KCV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SB_t_Delay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SB_T_Env)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sb_Td)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sb_Kp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sb_Ti)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtBx_conStatus
            // 
            this.txtBx_conStatus.BackColor = System.Drawing.SystemColors.Control;
            this.txtBx_conStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_conStatus.Location = new System.Drawing.Point(237, 53);
            this.txtBx_conStatus.Name = "txtBx_conStatus";
            this.txtBx_conStatus.ReadOnly = true;
            this.txtBx_conStatus.Size = new System.Drawing.Size(100, 13);
            this.txtBx_conStatus.TabIndex = 34;
            // 
            // Graph_Temperature
            // 
            this.Graph_Temperature.Location = new System.Drawing.Point(5, 6);
            this.Graph_Temperature.Name = "Graph_Temperature";
            this.Graph_Temperature.PlotAreaColor = System.Drawing.SystemColors.ControlLightLight;
            this.Graph_Temperature.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.Graph_Temp});
            this.Graph_Temperature.Size = new System.Drawing.Size(724, 334);
            this.Graph_Temperature.TabIndex = 35;
            this.Graph_Temperature.UseColorGenerator = true;
            this.Graph_Temperature.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis4});
            this.Graph_Temperature.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis4});
            // 
            // Graph_Temp
            // 
            this.Graph_Temp.FillBase = NationalInstruments.UI.XYPlotFillBase.Plot;
            this.Graph_Temp.FillMode = NationalInstruments.UI.PlotFillMode.Lines;
            this.Graph_Temp.LineColor = System.Drawing.SystemColors.Highlight;
            this.Graph_Temp.LineColorPrecedence = NationalInstruments.UI.ColorPrecedence.UserDefinedColor;
            this.Graph_Temp.LineWidth = 2F;
            this.Graph_Temp.PointColor = System.Drawing.SystemColors.WindowText;
            this.Graph_Temp.XAxis = this.xAxis4;
            this.Graph_Temp.YAxis = this.yAxis4;
            this.Graph_Temp.YErrorHighLineColor = System.Drawing.Color.Cyan;
            // 
            // xAxis4
            // 
            this.xAxis4.BaseLineVisible = true;
            this.xAxis4.Caption = "Seconds";
            this.xAxis4.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xAxis4.Mode = NationalInstruments.UI.AxisMode.StripChart;
            this.xAxis4.Range = new NationalInstruments.UI.Range(0D, 100D);
            // 
            // yAxis4
            // 
            this.yAxis4.BaseLineWidth = 2;
            this.yAxis4.Caption = "Measured Temperature [°C]";
            this.yAxis4.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yAxis4.Mode = NationalInstruments.UI.AxisMode.StripChart;
            this.yAxis4.Range = new NationalInstruments.UI.Range(30D, 37D);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Td[s]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ti[s]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kp";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 16);
            this.label9.TabIndex = 41;
            this.label9.Text = "Time constant [s]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 40;
            this.label8.Text = "K[C/V]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "T delay [s]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "T env [°C]";
            // 
            // Btn_Start
            // 
            this.Btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Start.Location = new System.Drawing.Point(22, 45);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(75, 23);
            this.Btn_Start.TabIndex = 29;
            this.Btn_Start.Text = "Start";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // TxtBx_Status
            // 
            this.TxtBx_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBx_Status.Location = new System.Drawing.Point(22, 19);
            this.TxtBx_Status.Name = "TxtBx_Status";
            this.TxtBx_Status.ReadOnly = true;
            this.TxtBx_Status.Size = new System.Drawing.Size(72, 22);
            this.TxtBx_Status.TabIndex = 28;
            // 
            // Graph_ControlSignalU
            // 
            this.Graph_ControlSignalU.Location = new System.Drawing.Point(3, 6);
            this.Graph_ControlSignalU.Name = "Graph_ControlSignalU";
            this.Graph_ControlSignalU.PlotAreaColor = System.Drawing.SystemColors.ControlLightLight;
            this.Graph_ControlSignalU.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.Graph_U});
            this.Graph_ControlSignalU.Size = new System.Drawing.Size(727, 334);
            this.Graph_ControlSignalU.TabIndex = 37;
            this.Graph_ControlSignalU.UseColorGenerator = true;
            this.Graph_ControlSignalU.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis1});
            this.Graph_ControlSignalU.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis1});
            // 
            // Graph_U
            // 
            this.Graph_U.FillBase = NationalInstruments.UI.XYPlotFillBase.Plot;
            this.Graph_U.FillMode = NationalInstruments.UI.PlotFillMode.Lines;
            this.Graph_U.LineColor = System.Drawing.SystemColors.Highlight;
            this.Graph_U.LineColorPrecedence = NationalInstruments.UI.ColorPrecedence.UserDefinedColor;
            this.Graph_U.LineWidth = 2F;
            this.Graph_U.PointColor = System.Drawing.SystemColors.WindowText;
            this.Graph_U.XAxis = this.xAxis1;
            this.Graph_U.YAxis = this.yAxis1;
            this.Graph_U.YErrorHighLineColor = System.Drawing.Color.Cyan;
            // 
            // xAxis1
            // 
            this.xAxis1.BaseLineVisible = true;
            this.xAxis1.Caption = "Seconds";
            this.xAxis1.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xAxis1.Mode = NationalInstruments.UI.AxisMode.StripChart;
            this.xAxis1.Range = new NationalInstruments.UI.Range(0D, 100D);
            // 
            // yAxis1
            // 
            this.yAxis1.Caption = "Control signal U [v]";
            this.yAxis1.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yAxis1.Mode = NationalInstruments.UI.AxisMode.Fixed;
            this.yAxis1.Range = new NationalInstruments.UI.Range(0D, 5D);
            // 
            // TxtBx_ActualTemp
            // 
            this.TxtBx_ActualTemp.Location = new System.Drawing.Point(66, 26);
            this.TxtBx_ActualTemp.Name = "TxtBx_ActualTemp";
            this.TxtBx_ActualTemp.ReadOnly = true;
            this.TxtBx_ActualTemp.Size = new System.Drawing.Size(47, 22);
            this.TxtBx_ActualTemp.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 16);
            this.label12.TabIndex = 39;
            this.label12.Text = "Actual:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 16);
            this.label13.TabIndex = 40;
            this.label13.Text = "Setpoint:";
            // 
            // Gb_Temp
            // 
            this.Gb_Temp.Controls.Add(this.sb_TempSP);
            this.Gb_Temp.Controls.Add(this.label12);
            this.Gb_Temp.Controls.Add(this.TxtBx_ActualTemp);
            this.Gb_Temp.Controls.Add(this.label13);
            this.Gb_Temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gb_Temp.Location = new System.Drawing.Point(753, 131);
            this.Gb_Temp.Name = "Gb_Temp";
            this.Gb_Temp.Size = new System.Drawing.Size(124, 97);
            this.Gb_Temp.TabIndex = 42;
            this.Gb_Temp.TabStop = false;
            this.Gb_Temp.Text = "Temperature [°C]";
            // 
            // sb_TempSP
            // 
            this.sb_TempSP.DecimalPlaces = 1;
            this.sb_TempSP.Location = new System.Drawing.Point(66, 58);
            this.sb_TempSP.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.sb_TempSP.Name = "sb_TempSP";
            this.sb_TempSP.Size = new System.Drawing.Size(47, 22);
            this.sb_TempSP.TabIndex = 45;
            this.sb_TempSP.ValueChanged += new System.EventHandler(this.sb_TempSP_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Start);
            this.groupBox1.Controls.Add(this.TxtBx_Status);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(753, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 77);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(8, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(743, 372);
            this.tabControl1.TabIndex = 44;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Graph_Temperature);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(735, 343);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Temperature";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.Graph_ControlSignalU);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(735, 343);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Control signal";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox4);
            this.tabPage5.Controls.Add(this.groupBox3);
            this.tabPage5.Controls.Add(this.groupBox2);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(735, 343);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Configuration";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CB_RealProc);
            this.groupBox4.Controls.Add(this.CB_Mode);
            this.groupBox4.Controls.Add(this.sb_ManModeVolt);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(332, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(155, 157);
            this.groupBox4.TabIndex = 47;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Control";
            // 
            // CB_RealProc
            // 
            this.CB_RealProc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_RealProc.FormattingEnabled = true;
            this.CB_RealProc.Items.AddRange(new object[] {
            "Simulate process",
            "Real process"});
            this.CB_RealProc.Location = new System.Drawing.Point(6, 21);
            this.CB_RealProc.Name = "CB_RealProc";
            this.CB_RealProc.Size = new System.Drawing.Size(128, 24);
            this.CB_RealProc.TabIndex = 51;
            this.CB_RealProc.SelectedIndexChanged += new System.EventHandler(this.CB_RealProc_SelectedIndexChanged);
            // 
            // CB_Mode
            // 
            this.CB_Mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Mode.FormattingEnabled = true;
            this.CB_Mode.Items.AddRange(new object[] {
            "Automatic mode",
            "Manual mode"});
            this.CB_Mode.Location = new System.Drawing.Point(6, 52);
            this.CB_Mode.Name = "CB_Mode";
            this.CB_Mode.Size = new System.Drawing.Size(128, 24);
            this.CB_Mode.TabIndex = 50;
            this.CB_Mode.SelectedIndexChanged += new System.EventHandler(this.CB_Mode_SelectedIndexChanged);
            // 
            // sb_ManModeVolt
            // 
            this.sb_ManModeVolt.DecimalPlaces = 1;
            this.sb_ManModeVolt.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.sb_ManModeVolt.Location = new System.Drawing.Point(6, 90);
            this.sb_ManModeVolt.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.sb_ManModeVolt.Name = "sb_ManModeVolt";
            this.sb_ManModeVolt.Size = new System.Drawing.Size(51, 22);
            this.sb_ManModeVolt.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 48);
            this.label2.TabIndex = 48;
            this.label2.Text = "Control signal\r\nmanual mode\r\n[0-5 V]";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this.SB_TimeConstant);
            this.groupBox3.Controls.Add(this.SB_KCV);
            this.groupBox3.Controls.Add(this.SB_t_Delay);
            this.groupBox3.Controls.Add(this.SB_T_Env);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(138, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(187, 157);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Simulation";
            // 
            // SB_TimeConstant
            // 
            this.SB_TimeConstant.DecimalPlaces = 1;
            this.SB_TimeConstant.Location = new System.Drawing.Point(117, 125);
            this.SB_TimeConstant.Name = "SB_TimeConstant";
            this.SB_TimeConstant.Size = new System.Drawing.Size(51, 22);
            this.SB_TimeConstant.TabIndex = 51;
            this.SB_TimeConstant.ValueChanged += new System.EventHandler(this.SB_TimeConstant_ValueChanged);
            // 
            // SB_KCV
            // 
            this.SB_KCV.DecimalPlaces = 1;
            this.SB_KCV.Location = new System.Drawing.Point(117, 93);
            this.SB_KCV.Name = "SB_KCV";
            this.SB_KCV.Size = new System.Drawing.Size(51, 22);
            this.SB_KCV.TabIndex = 50;
            this.SB_KCV.ValueChanged += new System.EventHandler(this.SB_KCV_ValueChanged);
            // 
            // SB_t_Delay
            // 
            this.SB_t_Delay.DecimalPlaces = 1;
            this.SB_t_Delay.Location = new System.Drawing.Point(117, 56);
            this.SB_t_Delay.Name = "SB_t_Delay";
            this.SB_t_Delay.Size = new System.Drawing.Size(51, 22);
            this.SB_t_Delay.TabIndex = 49;
            this.SB_t_Delay.ValueChanged += new System.EventHandler(this.SB_t_Delay_ValueChanged);
            // 
            // SB_T_Env
            // 
            this.SB_T_Env.DecimalPlaces = 1;
            this.SB_T_Env.Location = new System.Drawing.Point(117, 19);
            this.SB_T_Env.Name = "SB_T_Env";
            this.SB_T_Env.Size = new System.Drawing.Size(51, 22);
            this.SB_T_Env.TabIndex = 48;
            this.SB_T_Env.ValueChanged += new System.EventHandler(this.SB_T_Env_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.sb_Td);
            this.groupBox2.Controls.Add(this.sb_Kp);
            this.groupBox2.Controls.Add(this.sb_Ti);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(17, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(115, 157);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PID";
            // 
            // sb_Td
            // 
            this.sb_Td.DecimalPlaces = 1;
            this.sb_Td.Location = new System.Drawing.Point(51, 95);
            this.sb_Td.Name = "sb_Td";
            this.sb_Td.Size = new System.Drawing.Size(51, 22);
            this.sb_Td.TabIndex = 48;
            this.sb_Td.ValueChanged += new System.EventHandler(this.sb_Td_ValueChanged);
            // 
            // sb_Kp
            // 
            this.sb_Kp.DecimalPlaces = 1;
            this.sb_Kp.Location = new System.Drawing.Point(51, 19);
            this.sb_Kp.Name = "sb_Kp";
            this.sb_Kp.Size = new System.Drawing.Size(51, 22);
            this.sb_Kp.TabIndex = 46;
            this.sb_Kp.ValueChanged += new System.EventHandler(this.sb_Kp_ValueChanged);
            // 
            // sb_Ti
            // 
            this.sb_Ti.DecimalPlaces = 1;
            this.sb_Ti.Location = new System.Drawing.Point(51, 57);
            this.sb_Ti.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.sb_Ti.Name = "sb_Ti";
            this.sb_Ti.Size = new System.Drawing.Size(51, 22);
            this.sb_Ti.TabIndex = 47;
            this.sb_Ti.ValueChanged += new System.EventHandler(this.sb_Ti_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 387);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Gb_Temp);
            this.Controls.Add(this.txtBx_conStatus);
            this.Name = "Form1";
            this.Text = "Temperature controller";
            ((System.ComponentModel.ISupportInitialize)(this.Graph_Temperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Graph_ControlSignalU)).EndInit();
            this.Gb_Temp.ResumeLayout(false);
            this.Gb_Temp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sb_TempSP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sb_ManModeVolt)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SB_TimeConstant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SB_KCV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SB_t_Delay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SB_T_Env)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sb_Td)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sb_Kp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sb_Ti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtBx_conStatus;
        private NationalInstruments.UI.WindowsForms.WaveformGraph Graph_Temperature;
        private NationalInstruments.UI.WaveformPlot Graph_Temp;
        private NationalInstruments.UI.XAxis xAxis4;
        private NationalInstruments.UI.YAxis yAxis4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private NationalInstruments.UI.WindowsForms.WaveformGraph Graph_ControlSignalU;
        private NationalInstruments.UI.WaveformPlot Graph_U;
        private NationalInstruments.UI.XAxis xAxis1;
        private NationalInstruments.UI.YAxis yAxis1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtBx_ActualTemp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox Gb_Temp;
        private System.Windows.Forms.TextBox TxtBx_Status;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.NumericUpDown sb_TempSP;
        private System.Windows.Forms.NumericUpDown sb_Td;
        private System.Windows.Forms.NumericUpDown sb_Ti;
        private System.Windows.Forms.NumericUpDown sb_Kp;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown sb_ManModeVolt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_Mode;
        private System.Windows.Forms.ComboBox CB_RealProc;
        private System.Windows.Forms.NumericUpDown SB_TimeConstant;
        private System.Windows.Forms.NumericUpDown SB_KCV;
        private System.Windows.Forms.NumericUpDown SB_t_Delay;
        private System.Windows.Forms.NumericUpDown SB_T_Env;
    }
}

