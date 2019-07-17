namespace SDK_Example
{
    partial class formScan2D
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
            this.textRadius = new System.Windows.Forms.TextBox();
            this.labelProbeName = new System.Windows.Forms.Label();
            this.labelDepth = new System.Windows.Forms.Label();
            this.labelFrequency = new System.Windows.Forms.Label();
            this.labelRobotSpeed = new System.Windows.Forms.Label();
            this.labelMainGain = new System.Windows.Forms.Label();
            this.labelHighVolt = new System.Windows.Forms.Label();
            this.trackBarCine = new System.Windows.Forms.TrackBar();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonCine = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelFpga = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelFileName = new System.Windows.Forms.Label();
            this.labelDynamic = new System.Windows.Forms.Label();
            this.labelTgc3 = new System.Windows.Forms.Label();
            this.labelTgc2 = new System.Windows.Forms.Label();
            this.labelTgc1 = new System.Windows.Forms.Label();
            this.tBarTgc1 = new System.Windows.Forms.TrackBar();
            this.tBarTgc2 = new System.Windows.Forms.TrackBar();
            this.tBarTgc3 = new System.Windows.Forms.TrackBar();
            this.trackBarRobotSpeed = new System.Windows.Forms.TrackBar();
            this.labelSteering = new System.Windows.Forms.Label();
            this.labelFocus = new System.Windows.Forms.Label();
            this.butCfmMode = new System.Windows.Forms.Button();
            this.butRFMode = new System.Windows.Forms.Button();
            this.butDoubler = new System.Windows.Forms.Button();
            this.butCompound = new System.Windows.Forms.Button();
            this.buttonProbe1 = new System.Windows.Forms.Button();
            this.buttonProbe2 = new System.Windows.Forms.Button();
            this.buttonRobotScan = new System.Windows.Forms.Button();
            this.butManRev = new System.Windows.Forms.Button();
            this.butManFwd = new System.Windows.Forms.Button();
            this.labelPosition = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonSaveCine = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.uctrlPMSteering = new SDK_Example.UserControlPlusMinus();
            this.uctrlPMDynamic = new SDK_Example.UserControlPlusMinus();
            this.uctrlPMHighVoltage = new SDK_Example.UserControlPlusMinus();
            this.uctrlPMGalGain = new SDK_Example.UserControlPlusMinus();
            this.uctrlPMFocus = new SDK_Example.UserControlPlusMinus();
            this.uctrlPMFrequency = new SDK_Example.UserControlPlusMinus();
            this.uctrlPMDepth = new SDK_Example.UserControlPlusMinus();
            this.uctrlGrayScale = new SDK_Example.UserControlGrayScale();
            this.uctrlDepth = new SDK_Example.UserControlDepth();
            this.uctrlScan = new SDK_Example.UserControlScan();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCine)).BeginInit();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarTgc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarTgc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarTgc3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRobotSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // textRadius
            // 
            this.textRadius.Location = new System.Drawing.Point(904, 227);
            this.textRadius.Name = "textRadius";
            this.textRadius.Size = new System.Drawing.Size(200, 20);
            this.textRadius.TabIndex = 0;
            this.textRadius.Text = "Enter the Radius";
            this.textRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textRadius.TextChanged += new System.EventHandler(this.TextRadius_TextChanged);
            // 
            // labelProbeName
            // 
            this.labelProbeName.AutoSize = true;
            this.labelProbeName.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelProbeName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProbeName.ForeColor = System.Drawing.Color.Black;
            this.labelProbeName.Location = new System.Drawing.Point(22, 11);
            this.labelProbeName.MaximumSize = new System.Drawing.Size(200, 20);
            this.labelProbeName.MinimumSize = new System.Drawing.Size(10, 10);
            this.labelProbeName.Name = "labelProbeName";
            this.labelProbeName.Size = new System.Drawing.Size(10, 16);
            this.labelProbeName.TabIndex = 12;
            // 
            // labelDepth
            // 
            this.labelDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepth.Location = new System.Drawing.Point(101, 649);
            this.labelDepth.Name = "labelDepth";
            this.labelDepth.Size = new System.Drawing.Size(60, 16);
            this.labelDepth.TabIndex = 26;
            this.labelDepth.Text = "Depth";
            this.labelDepth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDepth.Click += new System.EventHandler(this.LabelDepth_Click);
            // 
            // labelFrequency
            // 
            this.labelFrequency.AutoSize = true;
            this.labelFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrequency.Location = new System.Drawing.Point(164, 649);
            this.labelFrequency.Name = "labelFrequency";
            this.labelFrequency.Size = new System.Drawing.Size(81, 16);
            this.labelFrequency.TabIndex = 27;
            this.labelFrequency.Text = "Frequency";
            // 
            // labelRobotSpeed
            // 
            this.labelRobotSpeed.AutoSize = true;
            this.labelRobotSpeed.Location = new System.Drawing.Point(959, 50);
            this.labelRobotSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRobotSpeed.Name = "labelRobotSpeed";
            this.labelRobotSpeed.Size = new System.Drawing.Size(70, 13);
            this.labelRobotSpeed.TabIndex = 57;
            this.labelRobotSpeed.Text = "Robot Speed";
            // 
            // labelMainGain
            // 
            this.labelMainGain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainGain.Location = new System.Drawing.Point(600, 649);
            this.labelMainGain.Name = "labelMainGain";
            this.labelMainGain.Size = new System.Drawing.Size(73, 16);
            this.labelMainGain.TabIndex = 32;
            this.labelMainGain.Text = "MainGain";
            this.labelMainGain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMainGain.Click += new System.EventHandler(this.LabelMainGain_Click);
            // 
            // labelHighVolt
            // 
            this.labelHighVolt.AutoSize = true;
            this.labelHighVolt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHighVolt.Location = new System.Drawing.Point(333, 649);
            this.labelHighVolt.Name = "labelHighVolt";
            this.labelHighVolt.Size = new System.Drawing.Size(71, 16);
            this.labelHighVolt.TabIndex = 34;
            this.labelHighVolt.Text = "High Volt";
            this.labelHighVolt.Click += new System.EventHandler(this.LabelHighVolt_Click);
            // 
            // trackBarCine
            // 
            this.trackBarCine.BackColor = System.Drawing.Color.Black;
            this.trackBarCine.Location = new System.Drawing.Point(794, 436);
            this.trackBarCine.Maximum = 512;
            this.trackBarCine.Name = "trackBarCine";
            this.trackBarCine.Size = new System.Drawing.Size(300, 45);
            this.trackBarCine.TabIndex = 5;
            this.trackBarCine.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarCine.Scroll += new System.EventHandler(this.trackBarCine_Scroll);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonPrevious.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrevious.ForeColor = System.Drawing.Color.Black;
            this.buttonPrevious.Location = new System.Drawing.Point(794, 362);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(90, 60);
            this.buttonPrevious.TabIndex = 4;
            this.buttonPrevious.Text = "Prev";
            this.buttonPrevious.UseVisualStyleBackColor = false;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonNext.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.ForeColor = System.Drawing.Color.Black;
            this.buttonNext.Location = new System.Drawing.Point(994, 362);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(90, 60);
            this.buttonNext.TabIndex = 3;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonCine
            // 
            this.buttonCine.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonCine.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCine.ForeColor = System.Drawing.Color.Black;
            this.buttonCine.Location = new System.Drawing.Point(894, 362);
            this.buttonCine.Name = "buttonCine";
            this.buttonCine.Size = new System.Drawing.Size(90, 60);
            this.buttonCine.TabIndex = 2;
            this.buttonCine.Text = "Play";
            this.buttonCine.UseVisualStyleBackColor = false;
            this.buttonCine.Click += new System.EventHandler(this.buttonCine_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.LightSteelBlue;
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripStatusLabelFpga});
            this.statusStrip.Location = new System.Drawing.Point(0, 727);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1166, 22);
            this.statusStrip.TabIndex = 35;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.ForeColor = System.Drawing.Color.Black;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(114, 17);
            this.toolStripStatusLabel.Text = "toolStripStatusLabel";
            // 
            // toolStripStatusLabelFpga
            // 
            this.toolStripStatusLabelFpga.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toolStripStatusLabelFpga.ForeColor = System.Drawing.Color.Black;
            this.toolStripStatusLabelFpga.Name = "toolStripStatusLabelFpga";
            this.toolStripStatusLabelFpga.Size = new System.Drawing.Size(140, 17);
            this.toolStripStatusLabelFpga.Text = "toolStripStatusLabelFpga";
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFileName.Location = new System.Drawing.Point(244, 13);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(75, 16);
            this.labelFileName.TabIndex = 39;
            this.labelFileName.Text = "FileName";
            // 
            // labelDynamic
            // 
            this.labelDynamic.AutoSize = true;
            this.labelDynamic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDynamic.Location = new System.Drawing.Point(680, 649);
            this.labelDynamic.Name = "labelDynamic";
            this.labelDynamic.Size = new System.Drawing.Size(68, 16);
            this.labelDynamic.TabIndex = 44;
            this.labelDynamic.Text = "Dynamic";
            // 
            // labelTgc3
            // 
            this.labelTgc3.AutoSize = true;
            this.labelTgc3.Location = new System.Drawing.Point(879, 607);
            this.labelTgc3.Name = "labelTgc3";
            this.labelTgc3.Size = new System.Drawing.Size(22, 13);
            this.labelTgc3.TabIndex = 56;
            this.labelTgc3.Text = "Far";
            this.labelTgc3.Click += new System.EventHandler(this.LabelTgc3_Click);
            // 
            // labelTgc2
            // 
            this.labelTgc2.AutoSize = true;
            this.labelTgc2.Location = new System.Drawing.Point(871, 552);
            this.labelTgc2.Name = "labelTgc2";
            this.labelTgc2.Size = new System.Drawing.Size(38, 13);
            this.labelTgc2.TabIndex = 55;
            this.labelTgc2.Text = "Middle";
            // 
            // labelTgc1
            // 
            this.labelTgc1.AutoSize = true;
            this.labelTgc1.Location = new System.Drawing.Point(875, 498);
            this.labelTgc1.Name = "labelTgc1";
            this.labelTgc1.Size = new System.Drawing.Size(30, 13);
            this.labelTgc1.TabIndex = 54;
            this.labelTgc1.Text = "Near";
            this.labelTgc1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tBarTgc1
            // 
            this.tBarTgc1.BackColor = System.Drawing.Color.Black;
            this.tBarTgc1.Location = new System.Drawing.Point(771, 514);
            this.tBarTgc1.Maximum = 15;
            this.tBarTgc1.Minimum = -15;
            this.tBarTgc1.Name = "tBarTgc1";
            this.tBarTgc1.Size = new System.Drawing.Size(240, 45);
            this.tBarTgc1.TabIndex = 53;
            this.tBarTgc1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tBarTgc1.Scroll += new System.EventHandler(this.tBarTgc1_Scroll);
            // 
            // tBarTgc2
            // 
            this.tBarTgc2.BackColor = System.Drawing.Color.Black;
            this.tBarTgc2.Location = new System.Drawing.Point(772, 568);
            this.tBarTgc2.Maximum = 15;
            this.tBarTgc2.Minimum = -15;
            this.tBarTgc2.Name = "tBarTgc2";
            this.tBarTgc2.Size = new System.Drawing.Size(240, 45);
            this.tBarTgc2.TabIndex = 46;
            this.tBarTgc2.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tBarTgc2.Scroll += new System.EventHandler(this.tBarTgc2_Scroll);
            // 
            // tBarTgc3
            // 
            this.tBarTgc3.BackColor = System.Drawing.Color.Black;
            this.tBarTgc3.Location = new System.Drawing.Point(771, 623);
            this.tBarTgc3.Maximum = 15;
            this.tBarTgc3.Minimum = -15;
            this.tBarTgc3.Name = "tBarTgc3";
            this.tBarTgc3.Size = new System.Drawing.Size(240, 45);
            this.tBarTgc3.TabIndex = 47;
            this.tBarTgc3.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tBarTgc3.Scroll += new System.EventHandler(this.tBarTgc3_Scroll);
            // 
            // trackBarRobotSpeed
            // 
            this.trackBarRobotSpeed.BackColor = System.Drawing.Color.Black;
            this.trackBarRobotSpeed.Location = new System.Drawing.Point(908, 70);
            this.trackBarRobotSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarRobotSpeed.Maximum = 100;
            this.trackBarRobotSpeed.Name = "trackBarRobotSpeed";
            this.trackBarRobotSpeed.Size = new System.Drawing.Size(187, 45);
            this.trackBarRobotSpeed.TabIndex = 53;
            this.trackBarRobotSpeed.TickFrequency = 5;
            this.trackBarRobotSpeed.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarRobotSpeed.Scroll += new System.EventHandler(this.trackBarRobotSpeed_Scroll);
            // 
            // labelSteering
            // 
            this.labelSteering.AutoSize = true;
            this.labelSteering.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSteering.Location = new System.Drawing.Point(1029, 649);
            this.labelSteering.Name = "labelSteering";
            this.labelSteering.Size = new System.Drawing.Size(66, 16);
            this.labelSteering.TabIndex = 47;
            this.labelSteering.Text = "Steering";
            // 
            // labelFocus
            // 
            this.labelFocus.AutoSize = true;
            this.labelFocus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFocus.Location = new System.Drawing.Point(260, 649);
            this.labelFocus.Name = "labelFocus";
            this.labelFocus.Size = new System.Drawing.Size(50, 16);
            this.labelFocus.TabIndex = 46;
            this.labelFocus.Text = "Focus";
            this.labelFocus.Click += new System.EventHandler(this.LabelFocus_Click);
            // 
            // butCfmMode
            // 
            this.butCfmMode.BackColor = System.Drawing.Color.LightSteelBlue;
            this.butCfmMode.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCfmMode.ForeColor = System.Drawing.Color.Black;
            this.butCfmMode.Location = new System.Drawing.Point(671, -211);
            this.butCfmMode.Name = "butCfmMode";
            this.butCfmMode.Size = new System.Drawing.Size(131, 26);
            this.butCfmMode.TabIndex = 53;
            this.butCfmMode.Text = "CFM";
            this.butCfmMode.UseVisualStyleBackColor = false;
            this.butCfmMode.Click += new System.EventHandler(this.butCfmMode_Click);
            // 
            // butRFMode
            // 
            this.butRFMode.BackColor = System.Drawing.Color.LightSteelBlue;
            this.butRFMode.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butRFMode.ForeColor = System.Drawing.Color.Black;
            this.butRFMode.Location = new System.Drawing.Point(418, 635);
            this.butRFMode.Name = "butRFMode";
            this.butRFMode.Size = new System.Drawing.Size(170, 30);
            this.butRFMode.TabIndex = 52;
            this.butRFMode.Text = "RF";
            this.butRFMode.UseVisualStyleBackColor = false;
            this.butRFMode.Click += new System.EventHandler(this.butRFMode_Click);
            // 
            // butDoubler
            // 
            this.butDoubler.BackColor = System.Drawing.Color.LightSteelBlue;
            this.butDoubler.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDoubler.ForeColor = System.Drawing.Color.Black;
            this.butDoubler.Location = new System.Drawing.Point(418, 603);
            this.butDoubler.Name = "butDoubler";
            this.butDoubler.Size = new System.Drawing.Size(170, 30);
            this.butDoubler.TabIndex = 51;
            this.butDoubler.Text = "Doubler";
            this.butDoubler.UseVisualStyleBackColor = false;
            this.butDoubler.Click += new System.EventHandler(this.butDoubler_Click);
            // 
            // butCompound
            // 
            this.butCompound.BackColor = System.Drawing.Color.LightSteelBlue;
            this.butCompound.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCompound.ForeColor = System.Drawing.Color.Black;
            this.butCompound.Location = new System.Drawing.Point(418, 571);
            this.butCompound.Name = "butCompound";
            this.butCompound.Size = new System.Drawing.Size(170, 30);
            this.butCompound.TabIndex = 50;
            this.butCompound.Text = "Compound";
            this.butCompound.UseVisualStyleBackColor = false;
            this.butCompound.Click += new System.EventHandler(this.butCompound_Click);
            // 
            // buttonProbe1
            // 
            this.buttonProbe1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonProbe1.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProbe1.ForeColor = System.Drawing.Color.Black;
            this.buttonProbe1.Location = new System.Drawing.Point(418, 539);
            this.buttonProbe1.Name = "buttonProbe1";
            this.buttonProbe1.Size = new System.Drawing.Size(170, 30);
            this.buttonProbe1.TabIndex = 47;
            this.buttonProbe1.Text = "Probe1";
            this.buttonProbe1.UseVisualStyleBackColor = false;
            this.buttonProbe1.Click += new System.EventHandler(this.buttonProbe1_Click);
            // 
            // buttonProbe2
            // 
            this.buttonProbe2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonProbe2.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProbe2.ForeColor = System.Drawing.Color.Black;
            this.buttonProbe2.Location = new System.Drawing.Point(9, 51);
            this.buttonProbe2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonProbe2.Name = "buttonProbe2";
            this.buttonProbe2.Size = new System.Drawing.Size(196, 40);
            this.buttonProbe2.TabIndex = 48;
            this.buttonProbe2.Text = "Probe2";
            this.buttonProbe2.UseVisualStyleBackColor = false;
            this.buttonProbe2.Click += new System.EventHandler(this.buttonProbe2_Click);
            // 
            // buttonRobotScan
            // 
            this.buttonRobotScan.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonRobotScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.buttonRobotScan.ForeColor = System.Drawing.Color.Black;
            this.buttonRobotScan.Location = new System.Drawing.Point(794, 50);
            this.buttonRobotScan.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRobotScan.Name = "buttonRobotScan";
            this.buttonRobotScan.Size = new System.Drawing.Size(100, 200);
            this.buttonRobotScan.TabIndex = 1;
            this.buttonRobotScan.Text = "Robot Scan";
            this.buttonRobotScan.UseVisualStyleBackColor = false;
            this.buttonRobotScan.Click += new System.EventHandler(this.robotScanButton_Click);
            // 
            // butManRev
            // 
            this.butManRev.Location = new System.Drawing.Point(908, 119);
            this.butManRev.Margin = new System.Windows.Forms.Padding(2);
            this.butManRev.Name = "butManRev";
            this.butManRev.Size = new System.Drawing.Size(58, 36);
            this.butManRev.TabIndex = 0;
            this.butManRev.Text = "Reverse";
            this.butManRev.UseVisualStyleBackColor = true;
            this.butManRev.MouseDown += new System.Windows.Forms.MouseEventHandler(this.butManRev_MouseDown);
            this.butManRev.MouseUp += new System.Windows.Forms.MouseEventHandler(this.butManRev_MouseUp);
            // 
            // butManFwd
            // 
            this.butManFwd.Location = new System.Drawing.Point(1037, 119);
            this.butManFwd.Margin = new System.Windows.Forms.Padding(2);
            this.butManFwd.Name = "butManFwd";
            this.butManFwd.Size = new System.Drawing.Size(58, 36);
            this.butManFwd.TabIndex = 1;
            this.butManFwd.Text = "Forward";
            this.butManFwd.UseVisualStyleBackColor = true;
            this.butManFwd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.butManFwd_MouseDown);
            this.butManFwd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.butManFwd_MouseUp);
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(978, 130);
            this.labelPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(44, 13);
            this.labelPosition.TabIndex = 2;
            this.labelPosition.Text = "Position";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(909, 168);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(187, 45);
            this.trackBar1.TabIndex = 3;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonSave.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.Black;
            this.buttonSave.Location = new System.Drawing.Point(794, 296);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(90, 60);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonSaveCine
            // 
            this.buttonSaveCine.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonSaveCine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.buttonSaveCine.ForeColor = System.Drawing.Color.Black;
            this.buttonSaveCine.Location = new System.Drawing.Point(994, 296);
            this.buttonSaveCine.Name = "buttonSaveCine";
            this.buttonSaveCine.Size = new System.Drawing.Size(90, 60);
            this.buttonSaveCine.TabIndex = 2;
            this.buttonSaveCine.Text = "Save Cine";
            this.buttonSaveCine.UseVisualStyleBackColor = false;
            this.buttonSaveCine.Click += new System.EventHandler(this.buttonSaveCine_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonLoad.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoad.ForeColor = System.Drawing.Color.Black;
            this.buttonLoad.Location = new System.Drawing.Point(894, 296);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(90, 60);
            this.buttonLoad.TabIndex = 3;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // uctrlPMSteering
            // 
            this.uctrlPMSteering.BackColor = System.Drawing.Color.LightSteelBlue;
            this.uctrlPMSteering.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uctrlPMSteering.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uctrlPMSteering.ForeColor = System.Drawing.Color.Black;
            this.uctrlPMSteering.Location = new System.Drawing.Point(1030, 539);
            this.uctrlPMSteering.Margin = new System.Windows.Forms.Padding(0);
            this.uctrlPMSteering.Name = "uctrlPMSteering";
            this.uctrlPMSteering.Size = new System.Drawing.Size(65, 110);
            this.uctrlPMSteering.TabIndex = 0;
            // 
            // uctrlPMDynamic
            // 
            this.uctrlPMDynamic.BackColor = System.Drawing.Color.LightSteelBlue;
            this.uctrlPMDynamic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uctrlPMDynamic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uctrlPMDynamic.ForeColor = System.Drawing.Color.Black;
            this.uctrlPMDynamic.Location = new System.Drawing.Point(683, 539);
            this.uctrlPMDynamic.Margin = new System.Windows.Forms.Padding(0);
            this.uctrlPMDynamic.Name = "uctrlPMDynamic";
            this.uctrlPMDynamic.Size = new System.Drawing.Size(65, 110);
            this.uctrlPMDynamic.TabIndex = 23;
            // 
            // uctrlPMHighVoltage
            // 
            this.uctrlPMHighVoltage.BackColor = System.Drawing.Color.LightSteelBlue;
            this.uctrlPMHighVoltage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uctrlPMHighVoltage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uctrlPMHighVoltage.ForeColor = System.Drawing.Color.Black;
            this.uctrlPMHighVoltage.Location = new System.Drawing.Point(336, 539);
            this.uctrlPMHighVoltage.Margin = new System.Windows.Forms.Padding(0);
            this.uctrlPMHighVoltage.Name = "uctrlPMHighVoltage";
            this.uctrlPMHighVoltage.Size = new System.Drawing.Size(65, 110);
            this.uctrlPMHighVoltage.TabIndex = 23;
            this.uctrlPMHighVoltage.Load += new System.EventHandler(this.UctrlPMHighVoltage_Load);
            // 
            // uctrlPMGalGain
            // 
            this.uctrlPMGalGain.BackColor = System.Drawing.Color.LightSteelBlue;
            this.uctrlPMGalGain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uctrlPMGalGain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uctrlPMGalGain.ForeColor = System.Drawing.Color.Black;
            this.uctrlPMGalGain.Location = new System.Drawing.Point(603, 539);
            this.uctrlPMGalGain.Margin = new System.Windows.Forms.Padding(0);
            this.uctrlPMGalGain.Name = "uctrlPMGalGain";
            this.uctrlPMGalGain.Size = new System.Drawing.Size(65, 110);
            this.uctrlPMGalGain.TabIndex = 22;
            // 
            // uctrlPMFocus
            // 
            this.uctrlPMFocus.BackColor = System.Drawing.Color.LightSteelBlue;
            this.uctrlPMFocus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uctrlPMFocus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uctrlPMFocus.ForeColor = System.Drawing.Color.Black;
            this.uctrlPMFocus.Location = new System.Drawing.Point(256, 539);
            this.uctrlPMFocus.Margin = new System.Windows.Forms.Padding(0);
            this.uctrlPMFocus.Name = "uctrlPMFocus";
            this.uctrlPMFocus.Size = new System.Drawing.Size(65, 110);
            this.uctrlPMFocus.TabIndex = 22;
            // 
            // uctrlPMFrequency
            // 
            this.uctrlPMFrequency.BackColor = System.Drawing.Color.LightSteelBlue;
            this.uctrlPMFrequency.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uctrlPMFrequency.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uctrlPMFrequency.ForeColor = System.Drawing.Color.Black;
            this.uctrlPMFrequency.Location = new System.Drawing.Point(176, 539);
            this.uctrlPMFrequency.Margin = new System.Windows.Forms.Padding(0);
            this.uctrlPMFrequency.Name = "uctrlPMFrequency";
            this.uctrlPMFrequency.Size = new System.Drawing.Size(65, 110);
            this.uctrlPMFrequency.TabIndex = 20;
            // 
            // uctrlPMDepth
            // 
            this.uctrlPMDepth.BackColor = System.Drawing.Color.LightSteelBlue;
            this.uctrlPMDepth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uctrlPMDepth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uctrlPMDepth.ForeColor = System.Drawing.Color.Black;
            this.uctrlPMDepth.Location = new System.Drawing.Point(96, 539);
            this.uctrlPMDepth.Margin = new System.Windows.Forms.Padding(0);
            this.uctrlPMDepth.Name = "uctrlPMDepth";
            this.uctrlPMDepth.Size = new System.Drawing.Size(65, 110);
            this.uctrlPMDepth.TabIndex = 19;
            this.uctrlPMDepth.Load += new System.EventHandler(this.UctrlPMDepth_Load);
            // 
            // uctrlGrayScale
            // 
            this.uctrlGrayScale.BackColor = System.Drawing.Color.Black;
            this.uctrlGrayScale.Enabled = false;
            this.uctrlGrayScale.Location = new System.Drawing.Point(613, 47);
            this.uctrlGrayScale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uctrlGrayScale.Name = "uctrlGrayScale";
            this.uctrlGrayScale.Size = new System.Drawing.Size(8, 512);
            this.uctrlGrayScale.TabIndex = 36;
            this.uctrlGrayScale.Visible = false;
            this.uctrlGrayScale.Paint += new System.Windows.Forms.PaintEventHandler(this.uctrlGrayScale_Paint);
            // 
            // uctrlDepth
            // 
            this.uctrlDepth.BackColor = System.Drawing.Color.Black;
            this.uctrlDepth.Location = new System.Drawing.Point(69, 37);
            this.uctrlDepth.Name = "uctrlDepth";
            this.uctrlDepth.Size = new System.Drawing.Size(30, 522);
            this.uctrlDepth.TabIndex = 13;
            this.uctrlDepth.Paint += new System.Windows.Forms.PaintEventHandler(this.uctrlDepth_Paint);
            // 
            // uctrlScan
            // 
            this.uctrlScan.BackColor = System.Drawing.Color.Transparent;
            this.uctrlScan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uctrlScan.ForeColor = System.Drawing.Color.Transparent;
            this.uctrlScan.Location = new System.Drawing.Point(100, 47);
            this.uctrlScan.Name = "uctrlScan";
            this.uctrlScan.Size = new System.Drawing.Size(640, 480);
            this.uctrlScan.TabIndex = 9;
            this.uctrlScan.Visible = false;
            this.uctrlScan.Paint += new System.Windows.Forms.PaintEventHandler(this.uctrlScan_Paint);
            this.uctrlScan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.uctrlScan_MouseClick);
            this.uctrlScan.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.uctrlScan_MouseDoubleClick);
            this.uctrlScan.MouseMove += new System.Windows.Forms.MouseEventHandler(this.uctrlScan_MouseMove);
            // 
            // formScan2D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1166, 749);
            this.Controls.Add(this.textRadius);
            this.Controls.Add(this.butCfmMode);
            this.Controls.Add(this.butRFMode);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.butDoubler);
            this.Controls.Add(this.buttonSaveCine);
            this.Controls.Add(this.butCompound);
            this.Controls.Add(this.buttonProbe1);
            this.Controls.Add(this.labelSteering);
            this.Controls.Add(this.trackBarCine);
            this.Controls.Add(this.labelFocus);
            this.Controls.Add(this.labelDynamic);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelMainGain);
            this.Controls.Add(this.labelHighVolt);
            this.Controls.Add(this.labelRobotSpeed);
            this.Controls.Add(this.labelFrequency);
            this.Controls.Add(this.labelDepth);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.labelTgc3);
            this.Controls.Add(this.buttonCine);
            this.Controls.Add(this.labelTgc2);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.labelTgc1);
            this.Controls.Add(this.uctrlPMSteering);
            this.Controls.Add(this.tBarTgc1);
            this.Controls.Add(this.butManFwd);
            this.Controls.Add(this.tBarTgc2);
            this.Controls.Add(this.tBarTgc3);
            this.Controls.Add(this.butManRev);
            this.Controls.Add(this.trackBarRobotSpeed);
            this.Controls.Add(this.uctrlPMDynamic);
            this.Controls.Add(this.uctrlPMHighVoltage);
            this.Controls.Add(this.uctrlPMGalGain);
            this.Controls.Add(this.uctrlPMFocus);
            this.Controls.Add(this.uctrlPMFrequency);
            this.Controls.Add(this.uctrlPMDepth);
            this.Controls.Add(this.buttonRobotScan);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.uctrlGrayScale);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.uctrlDepth);
            this.Controls.Add(this.labelProbeName);
            this.Controls.Add(this.uctrlScan);
            this.ForeColor = System.Drawing.Color.LightSlateGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(2046, 1274);
            this.MinimumSize = new System.Drawing.Size(510, 492);
            this.Name = "formScan2D";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SDK_Scan2D";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formScan2D_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formScan2D_FormClosed);
            this.Load += new System.EventHandler(this.formScan2D_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.formScan2D_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCine)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarTgc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarTgc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarTgc3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRobotSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControlScan uctrlScan;
        public System.Windows.Forms.Label labelProbeName;
        private UserControlDepth uctrlDepth;
        private System.Windows.Forms.Label labelDepth;
        private System.Windows.Forms.Label labelFrequency;
        // private System.Windows.Forms.Label labelImagesPer;
        private System.Windows.Forms.Label labelMainGain;
        private System.Windows.Forms.Label labelHighVolt;
        private System.Windows.Forms.Button buttonCine;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.TrackBar trackBarCine;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Label labelDynamic;
        private System.Windows.Forms.TrackBar tBarTgc2;
        private System.Windows.Forms.TrackBar tBarTgc3;
        private System.Windows.Forms.TrackBar tBarTgc1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelFpga;
        private System.Windows.Forms.Label labelTgc2;
        private System.Windows.Forms.Label labelTgc1;
        private System.Windows.Forms.Label labelTgc3;
        private UserControlGrayScale uctrlGrayScale;
        public System.Windows.Forms.Button buttonProbe1;
        private System.Windows.Forms.Label labelFocus;
        public System.Windows.Forms.Button butCompound;
        private System.Windows.Forms.Label labelSteering;
        public System.Windows.Forms.Button butDoubler;
        private UserControlPlusMinus uctrlPMDynamic;
        private UserControlPlusMinus uctrlPMGalGain;
        private UserControlPlusMinus uctrlPMSteering;
        public System.Windows.Forms.Button butRFMode;
        public System.Windows.Forms.Button butCfmMode;
        private System.Windows.Forms.Label labelRobotSpeed;
        private System.Windows.Forms.TrackBar trackBarRobotSpeed;
        public System.Windows.Forms.Button buttonProbe2; //not used
        // private UserControlPlusMinus uctrlImagesPer;
        private System.Windows.Forms.Button buttonRobotScan;
        private UserControlPlusMinus uctrlPMDepth;
        private UserControlPlusMinus uctrlPMFrequency;
        private UserControlPlusMinus uctrlPMFocus;
        private UserControlPlusMinus uctrlPMHighVoltage;
        private System.Windows.Forms.Button butManRev;
        private System.Windows.Forms.Button butManFwd;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonSaveCine;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.TextBox textRadius;
    }
}

