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
            this.buttonScan = new System.Windows.Forms.Button();
            this.labelProbeName = new System.Windows.Forms.Label();
            this.gBoxImaging = new System.Windows.Forms.GroupBox();
            this.uctrlPMHighVoltage = new SDK_Example.UserControlPlusMinus();
            this.uctrlPMFocus = new SDK_Example.UserControlPlusMinus();
            this.userControlPlusMinus3 = new SDK_Example.UserControlPlusMinus();
            this.uctrlPMFrequency = new SDK_Example.UserControlPlusMinus();
            this.uctrlPMDepth = new SDK_Example.UserControlPlusMinus();
            this.buttonRobotScan = new System.Windows.Forms.Button();
            this.gboxGain = new System.Windows.Forms.GroupBox();
            this.uctrlPMDynamic = new SDK_Example.UserControlPlusMinus();
            this.uctrlPMGalGain = new SDK_Example.UserControlPlusMinus();
            this.gboxImage = new System.Windows.Forms.GroupBox();
            this.buttonZoomBox = new System.Windows.Forms.Button();
            this.labelZoom = new System.Windows.Forms.Label();
            this.labelDepth = new System.Windows.Forms.Label();
            this.labelFrequency = new System.Windows.Forms.Label();
            this.labelImagesPer = new System.Windows.Forms.Label();
            this.gboxSave = new System.Windows.Forms.GroupBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSaveCine = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelRobotSpeed = new System.Windows.Forms.Label();
            this.labelMainGain = new System.Windows.Forms.Label();
            this.labelHighVolt = new System.Windows.Forms.Label();
            this.gBoxCineloop = new System.Windows.Forms.GroupBox();
            this.trackBarCine = new System.Windows.Forms.TrackBar();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonCine = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelFpga = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelFileName = new System.Windows.Forms.Label();
            this.labelDynamic = new System.Windows.Forms.Label();
            this.gBoxTgc = new System.Windows.Forms.GroupBox();
            this.labelTgc3 = new System.Windows.Forms.Label();
            this.labelTgc2 = new System.Windows.Forms.Label();
            this.labelTgc1 = new System.Windows.Forms.Label();
            this.tBarTgc1 = new System.Windows.Forms.TrackBar();
            this.tBarTgc2 = new System.Windows.Forms.TrackBar();
            this.tBarTgc3 = new System.Windows.Forms.TrackBar();
            this.trackBarRobotSpeed = new System.Windows.Forms.TrackBar();
            this.panelLabel = new System.Windows.Forms.Panel();
            this.labelCompound = new System.Windows.Forms.Label();
            this.labelSteering = new System.Windows.Forms.Label();
            this.labelFocus = new System.Windows.Forms.Label();
            this.labelFR = new System.Windows.Forms.Label();
            this.cboxSCSize = new System.Windows.Forms.ComboBox();
            this.panelSwitch = new System.Windows.Forms.Panel();
            this.butCfmMode = new System.Windows.Forms.Button();
            this.butRFMode = new System.Windows.Forms.Button();
            this.butDoubler = new System.Windows.Forms.Button();
            this.butCompound = new System.Windows.Forms.Button();
            this.buttonProbe1 = new System.Windows.Forms.Button();
            this.gboxAngle = new System.Windows.Forms.GroupBox();
            this.uctrlPMSteering = new SDK_Example.UserControlPlusMinus();
            this.buttonProbe2 = new System.Windows.Forms.Button();
            this.gboxImagesPer = new System.Windows.Forms.GroupBox();
            this.uctrlImagesPer = new SDK_Example.UserControlPlusMinus();
            this.gboxManual = new System.Windows.Forms.GroupBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.labelPosition = new System.Windows.Forms.Label();
            this.butManFwd = new System.Windows.Forms.Button();
            this.butManRev = new System.Windows.Forms.Button();
            this.uctrlGrayScale = new SDK_Example.UserControlGrayScale();
            this.uctrlDepth = new SDK_Example.UserControlDepth();
            this.uctrlScan = new SDK_Example.UserControlScan();
            this.gBoxImaging.SuspendLayout();
            this.gboxGain.SuspendLayout();
            this.gboxImage.SuspendLayout();
            this.gboxSave.SuspendLayout();
            this.gBoxCineloop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCine)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.gBoxTgc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarTgc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarTgc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarTgc3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRobotSpeed)).BeginInit();
            this.panelLabel.SuspendLayout();
            this.panelSwitch.SuspendLayout();
            this.gboxAngle.SuspendLayout();
            this.gboxImagesPer.SuspendLayout();
            this.gboxManual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonScan
            // 
            this.buttonScan.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonScan.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonScan.ForeColor = System.Drawing.Color.Black;
            this.buttonScan.Location = new System.Drawing.Point(11, 62);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(63, 42);
            this.buttonScan.TabIndex = 2;
            this.buttonScan.Text = "Scan";
            this.buttonScan.UseVisualStyleBackColor = false;
            this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
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
            // gBoxImaging
            // 
            this.gBoxImaging.BackColor = System.Drawing.Color.Transparent;
            this.gBoxImaging.Controls.Add(this.uctrlPMHighVoltage);
            this.gBoxImaging.Controls.Add(this.uctrlPMFocus);
            this.gBoxImaging.Controls.Add(this.userControlPlusMinus3);
            this.gBoxImaging.Controls.Add(this.uctrlPMFrequency);
            this.gBoxImaging.Controls.Add(this.uctrlPMDepth);
            this.gBoxImaging.Controls.Add(this.buttonScan);
            this.gBoxImaging.Controls.Add(this.buttonRobotScan);
            this.gBoxImaging.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxImaging.ForeColor = System.Drawing.Color.LightSlateGray;
            this.gBoxImaging.Location = new System.Drawing.Point(25, 569);
            this.gBoxImaging.Name = "gBoxImaging";
            this.gBoxImaging.Size = new System.Drawing.Size(311, 125);
            this.gBoxImaging.TabIndex = 22;
            this.gBoxImaging.TabStop = false;
            this.gBoxImaging.Text = "Imaging";
            // 
            // uctrlPMHighVoltage
            // 
            this.uctrlPMHighVoltage.BackColor = System.Drawing.Color.LightSteelBlue;
            this.uctrlPMHighVoltage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uctrlPMHighVoltage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uctrlPMHighVoltage.ForeColor = System.Drawing.Color.Black;
            this.uctrlPMHighVoltage.Location = new System.Drawing.Point(253, 16);
            this.uctrlPMHighVoltage.Margin = new System.Windows.Forms.Padding(0);
            this.uctrlPMHighVoltage.Name = "uctrlPMHighVoltage";
            this.uctrlPMHighVoltage.Size = new System.Drawing.Size(45, 100);
            this.uctrlPMHighVoltage.TabIndex = 23;
            // 
            // uctrlPMFocus
            // 
            this.uctrlPMFocus.BackColor = System.Drawing.Color.LightSteelBlue;
            this.uctrlPMFocus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uctrlPMFocus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uctrlPMFocus.ForeColor = System.Drawing.Color.Black;
            this.uctrlPMFocus.Location = new System.Drawing.Point(200, 17);
            this.uctrlPMFocus.Margin = new System.Windows.Forms.Padding(0);
            this.uctrlPMFocus.Name = "uctrlPMFocus";
            this.uctrlPMFocus.Size = new System.Drawing.Size(45, 100);
            this.uctrlPMFocus.TabIndex = 22;
            // 
            // userControlPlusMinus3
            // 
            this.userControlPlusMinus3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.userControlPlusMinus3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userControlPlusMinus3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userControlPlusMinus3.ForeColor = System.Drawing.Color.Black;
            this.userControlPlusMinus3.Location = new System.Drawing.Point(200, 44);
            this.userControlPlusMinus3.Margin = new System.Windows.Forms.Padding(0);
            this.userControlPlusMinus3.Name = "userControlPlusMinus3";
            this.userControlPlusMinus3.Size = new System.Drawing.Size(8, 8);
            this.userControlPlusMinus3.TabIndex = 21;
            // 
            // uctrlPMFrequency
            // 
            this.uctrlPMFrequency.BackColor = System.Drawing.Color.LightSteelBlue;
            this.uctrlPMFrequency.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uctrlPMFrequency.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uctrlPMFrequency.ForeColor = System.Drawing.Color.Black;
            this.uctrlPMFrequency.Location = new System.Drawing.Point(145, 17);
            this.uctrlPMFrequency.Margin = new System.Windows.Forms.Padding(0);
            this.uctrlPMFrequency.Name = "uctrlPMFrequency";
            this.uctrlPMFrequency.Size = new System.Drawing.Size(45, 100);
            this.uctrlPMFrequency.TabIndex = 20;
            // 
            // uctrlPMDepth
            // 
            this.uctrlPMDepth.BackColor = System.Drawing.Color.LightSteelBlue;
            this.uctrlPMDepth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uctrlPMDepth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uctrlPMDepth.ForeColor = System.Drawing.Color.Black;
            this.uctrlPMDepth.Location = new System.Drawing.Point(90, 17);
            this.uctrlPMDepth.Margin = new System.Windows.Forms.Padding(0);
            this.uctrlPMDepth.Name = "uctrlPMDepth";
            this.uctrlPMDepth.Size = new System.Drawing.Size(45, 100);
            this.uctrlPMDepth.TabIndex = 19;
            // 
            // buttonRobotScan
            // 
            this.buttonRobotScan.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonRobotScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.buttonRobotScan.ForeColor = System.Drawing.Color.Black;
            this.buttonRobotScan.Location = new System.Drawing.Point(11, 17);
            this.buttonRobotScan.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRobotScan.Name = "buttonRobotScan";
            this.buttonRobotScan.Size = new System.Drawing.Size(63, 40);
            this.buttonRobotScan.TabIndex = 1;
            this.buttonRobotScan.Text = "Robot Scan";
            this.buttonRobotScan.UseVisualStyleBackColor = false;
            this.buttonRobotScan.Click += new System.EventHandler(this.robotScanButton_Click);
            // 
            // gboxGain
            // 
            this.gboxGain.BackColor = System.Drawing.Color.Transparent;
            this.gboxGain.Controls.Add(this.uctrlPMDynamic);
            this.gboxGain.Controls.Add(this.uctrlPMGalGain);
            this.gboxGain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxGain.ForeColor = System.Drawing.Color.LightSlateGray;
            this.gboxGain.Location = new System.Drawing.Point(455, 569);
            this.gboxGain.Name = "gboxGain";
            this.gboxGain.Size = new System.Drawing.Size(123, 125);
            this.gboxGain.TabIndex = 23;
            this.gboxGain.TabStop = false;
            this.gboxGain.Text = "Gain";
            // 
            // uctrlPMDynamic
            // 
            this.uctrlPMDynamic.BackColor = System.Drawing.Color.LightSteelBlue;
            this.uctrlPMDynamic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uctrlPMDynamic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uctrlPMDynamic.ForeColor = System.Drawing.Color.Black;
            this.uctrlPMDynamic.Location = new System.Drawing.Point(70, 17);
            this.uctrlPMDynamic.Margin = new System.Windows.Forms.Padding(0);
            this.uctrlPMDynamic.Name = "uctrlPMDynamic";
            this.uctrlPMDynamic.Size = new System.Drawing.Size(45, 100);
            this.uctrlPMDynamic.TabIndex = 23;
            // 
            // uctrlPMGalGain
            // 
            this.uctrlPMGalGain.BackColor = System.Drawing.Color.LightSteelBlue;
            this.uctrlPMGalGain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uctrlPMGalGain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uctrlPMGalGain.ForeColor = System.Drawing.Color.Black;
            this.uctrlPMGalGain.Location = new System.Drawing.Point(15, 17);
            this.uctrlPMGalGain.Margin = new System.Windows.Forms.Padding(0);
            this.uctrlPMGalGain.Name = "uctrlPMGalGain";
            this.uctrlPMGalGain.Size = new System.Drawing.Size(45, 100);
            this.uctrlPMGalGain.TabIndex = 22;
            // 
            // gboxImage
            // 
            this.gboxImage.BackColor = System.Drawing.Color.Transparent;
            this.gboxImage.Controls.Add(this.buttonZoomBox);
            this.gboxImage.Controls.Add(this.labelZoom);
            this.gboxImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxImage.ForeColor = System.Drawing.Color.LightSlateGray;
            this.gboxImage.Location = new System.Drawing.Point(347, 569);
            this.gboxImage.Name = "gboxImage";
            this.gboxImage.Size = new System.Drawing.Size(102, 125);
            this.gboxImage.TabIndex = 25;
            this.gboxImage.TabStop = false;
            this.gboxImage.Text = "Image View";
            // 
            // buttonZoomBox
            // 
            this.buttonZoomBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonZoomBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZoomBox.ForeColor = System.Drawing.Color.Black;
            this.buttonZoomBox.Location = new System.Drawing.Point(8, 70);
            this.buttonZoomBox.Name = "buttonZoomBox";
            this.buttonZoomBox.Size = new System.Drawing.Size(80, 25);
            this.buttonZoomBox.TabIndex = 15;
            this.buttonZoomBox.Text = "Zoom Reset";
            this.buttonZoomBox.UseVisualStyleBackColor = false;
            this.buttonZoomBox.Click += new System.EventHandler(this.buttonZoomBox_Click);
            // 
            // labelZoom
            // 
            this.labelZoom.AutoSize = true;
            this.labelZoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZoom.Location = new System.Drawing.Point(5, 21);
            this.labelZoom.Name = "labelZoom";
            this.labelZoom.Size = new System.Drawing.Size(34, 13);
            this.labelZoom.TabIndex = 28;
            this.labelZoom.Text = "Zoom";
            // 
            // labelDepth
            // 
            this.labelDepth.AutoSize = true;
            this.labelDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepth.Location = new System.Drawing.Point(0, 0);
            this.labelDepth.Name = "labelDepth";
            this.labelDepth.Size = new System.Drawing.Size(49, 16);
            this.labelDepth.TabIndex = 26;
            this.labelDepth.Text = "Depth";
            // 
            // labelFrequency
            // 
            this.labelFrequency.AutoSize = true;
            this.labelFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrequency.Location = new System.Drawing.Point(0, 25);
            this.labelFrequency.Name = "labelFrequency";
            this.labelFrequency.Size = new System.Drawing.Size(81, 16);
            this.labelFrequency.TabIndex = 27;
            this.labelFrequency.Text = "Frequency";
            // 
            // labelImagesPer
            // 
            this.labelImagesPer.AutoSize = true;
            this.labelImagesPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImagesPer.Location = new System.Drawing.Point(4, 190);
            this.labelImagesPer.Name = "labelImagesPer";
            this.labelImagesPer.Size = new System.Drawing.Size(83, 16);
            this.labelImagesPer.TabIndex = 49;
            this.labelImagesPer.Text = "ImagesPer";
            // 
            // gboxSave
            // 
            this.gboxSave.BackColor = System.Drawing.Color.Transparent;
            this.gboxSave.Controls.Add(this.buttonLoad);
            this.gboxSave.Controls.Add(this.buttonSaveCine);
            this.gboxSave.Controls.Add(this.buttonSave);
            this.gboxSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxSave.ForeColor = System.Drawing.Color.LightSlateGray;
            this.gboxSave.Location = new System.Drawing.Point(805, 35);
            this.gboxSave.Name = "gboxSave";
            this.gboxSave.Size = new System.Drawing.Size(200, 95);
            this.gboxSave.TabIndex = 23;
            this.gboxSave.TabStop = false;
            this.gboxSave.Text = "Save/Load";
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonLoad.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoad.ForeColor = System.Drawing.Color.Black;
            this.buttonLoad.Location = new System.Drawing.Point(70, 25);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(60, 60);
            this.buttonLoad.TabIndex = 3;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSaveCine
            // 
            this.buttonSaveCine.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonSaveCine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.buttonSaveCine.ForeColor = System.Drawing.Color.Black;
            this.buttonSaveCine.Location = new System.Drawing.Point(133, 25);
            this.buttonSaveCine.Name = "buttonSaveCine";
            this.buttonSaveCine.Size = new System.Drawing.Size(60, 60);
            this.buttonSaveCine.TabIndex = 2;
            this.buttonSaveCine.Text = "Save Cine";
            this.buttonSaveCine.UseVisualStyleBackColor = false;
            this.buttonSaveCine.Click += new System.EventHandler(this.buttonSaveCine_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonSave.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.Black;
            this.buttonSave.Location = new System.Drawing.Point(6, 25);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(60, 60);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelRobotSpeed
            // 
            this.labelRobotSpeed.AutoSize = true;
            this.labelRobotSpeed.Location = new System.Drawing.Point(57, 181);
            this.labelRobotSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRobotSpeed.Name = "labelRobotSpeed";
            this.labelRobotSpeed.Size = new System.Drawing.Size(100, 16);
            this.labelRobotSpeed.TabIndex = 57;
            this.labelRobotSpeed.Text = "Robot Speed";
            // 
            // labelMainGain
            // 
            this.labelMainGain.AutoSize = true;
            this.labelMainGain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainGain.Location = new System.Drawing.Point(3, 77);
            this.labelMainGain.Name = "labelMainGain";
            this.labelMainGain.Size = new System.Drawing.Size(73, 16);
            this.labelMainGain.TabIndex = 32;
            this.labelMainGain.Text = "MainGain";
            // 
            // labelHighVolt
            // 
            this.labelHighVolt.AutoSize = true;
            this.labelHighVolt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHighVolt.Location = new System.Drawing.Point(0, 50);
            this.labelHighVolt.Name = "labelHighVolt";
            this.labelHighVolt.Size = new System.Drawing.Size(71, 16);
            this.labelHighVolt.TabIndex = 34;
            this.labelHighVolt.Text = "High Volt";
            // 
            // gBoxCineloop
            // 
            this.gBoxCineloop.BackColor = System.Drawing.Color.Transparent;
            this.gBoxCineloop.Controls.Add(this.trackBarCine);
            this.gBoxCineloop.Controls.Add(this.buttonPrevious);
            this.gBoxCineloop.Controls.Add(this.buttonNext);
            this.gBoxCineloop.Controls.Add(this.buttonCine);
            this.gBoxCineloop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxCineloop.ForeColor = System.Drawing.Color.LightSlateGray;
            this.gBoxCineloop.Location = new System.Drawing.Point(805, 140);
            this.gBoxCineloop.Name = "gBoxCineloop";
            this.gBoxCineloop.Size = new System.Drawing.Size(200, 140);
            this.gBoxCineloop.TabIndex = 24;
            this.gBoxCineloop.TabStop = false;
            this.gBoxCineloop.Text = "Cineloop";
            // 
            // trackBarCine
            // 
            this.trackBarCine.BackColor = System.Drawing.Color.Black;
            this.trackBarCine.Location = new System.Drawing.Point(5, 91);
            this.trackBarCine.Maximum = 512;
            this.trackBarCine.Name = "trackBarCine";
            this.trackBarCine.Size = new System.Drawing.Size(188, 45);
            this.trackBarCine.TabIndex = 5;
            this.trackBarCine.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarCine.Scroll += new System.EventHandler(this.trackBarCine_Scroll);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonPrevious.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrevious.ForeColor = System.Drawing.Color.Black;
            this.buttonPrevious.Location = new System.Drawing.Point(6, 25);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(60, 60);
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
            this.buttonNext.Location = new System.Drawing.Point(134, 25);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(60, 60);
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
            this.buttonCine.Location = new System.Drawing.Point(70, 25);
            this.buttonCine.Name = "buttonCine";
            this.buttonCine.Size = new System.Drawing.Size(60, 60);
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
            this.labelDynamic.Location = new System.Drawing.Point(3, 103);
            this.labelDynamic.Name = "labelDynamic";
            this.labelDynamic.Size = new System.Drawing.Size(68, 16);
            this.labelDynamic.TabIndex = 44;
            this.labelDynamic.Text = "Dynamic";
            // 
            // gBoxTgc
            // 
            this.gBoxTgc.BackColor = System.Drawing.Color.Transparent;
            this.gBoxTgc.Controls.Add(this.labelRobotSpeed);
            this.gBoxTgc.Controls.Add(this.labelTgc3);
            this.gBoxTgc.Controls.Add(this.labelTgc2);
            this.gBoxTgc.Controls.Add(this.labelTgc1);
            this.gBoxTgc.Controls.Add(this.tBarTgc1);
            this.gBoxTgc.Controls.Add(this.tBarTgc2);
            this.gBoxTgc.Controls.Add(this.tBarTgc3);
            this.gBoxTgc.Controls.Add(this.trackBarRobotSpeed);
            this.gBoxTgc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxTgc.ForeColor = System.Drawing.Color.LightSlateGray;
            this.gBoxTgc.Location = new System.Drawing.Point(805, 282);
            this.gBoxTgc.Name = "gBoxTgc";
            this.gBoxTgc.Size = new System.Drawing.Size(200, 250);
            this.gBoxTgc.TabIndex = 46;
            this.gBoxTgc.TabStop = false;
            this.gBoxTgc.Text = "TGC";
            // 
            // labelTgc3
            // 
            this.labelTgc3.AutoSize = true;
            this.labelTgc3.Location = new System.Drawing.Point(88, 123);
            this.labelTgc3.Name = "labelTgc3";
            this.labelTgc3.Size = new System.Drawing.Size(31, 16);
            this.labelTgc3.TabIndex = 56;
            this.labelTgc3.Text = "Far";
            // 
            // labelTgc2
            // 
            this.labelTgc2.AutoSize = true;
            this.labelTgc2.Location = new System.Drawing.Point(79, 68);
            this.labelTgc2.Name = "labelTgc2";
            this.labelTgc2.Size = new System.Drawing.Size(55, 16);
            this.labelTgc2.TabIndex = 55;
            this.labelTgc2.Text = "Middle";
            // 
            // labelTgc1
            // 
            this.labelTgc1.AutoSize = true;
            this.labelTgc1.Location = new System.Drawing.Point(79, 14);
            this.labelTgc1.Name = "labelTgc1";
            this.labelTgc1.Size = new System.Drawing.Size(42, 16);
            this.labelTgc1.TabIndex = 54;
            this.labelTgc1.Text = "Near";
            // 
            // tBarTgc1
            // 
            this.tBarTgc1.BackColor = System.Drawing.Color.Black;
            this.tBarTgc1.Location = new System.Drawing.Point(5, 34);
            this.tBarTgc1.Maximum = 15;
            this.tBarTgc1.Minimum = -15;
            this.tBarTgc1.Name = "tBarTgc1";
            this.tBarTgc1.Size = new System.Drawing.Size(188, 45);
            this.tBarTgc1.TabIndex = 53;
            this.tBarTgc1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tBarTgc1.Scroll += new System.EventHandler(this.tBarTgc1_Scroll);
            // 
            // tBarTgc2
            // 
            this.tBarTgc2.BackColor = System.Drawing.Color.Black;
            this.tBarTgc2.Location = new System.Drawing.Point(6, 88);
            this.tBarTgc2.Maximum = 15;
            this.tBarTgc2.Minimum = -15;
            this.tBarTgc2.Name = "tBarTgc2";
            this.tBarTgc2.Size = new System.Drawing.Size(188, 45);
            this.tBarTgc2.TabIndex = 46;
            this.tBarTgc2.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tBarTgc2.Scroll += new System.EventHandler(this.tBarTgc2_Scroll);
            // 
            // tBarTgc3
            // 
            this.tBarTgc3.BackColor = System.Drawing.Color.Black;
            this.tBarTgc3.Location = new System.Drawing.Point(5, 143);
            this.tBarTgc3.Maximum = 15;
            this.tBarTgc3.Minimum = -15;
            this.tBarTgc3.Name = "tBarTgc3";
            this.tBarTgc3.Size = new System.Drawing.Size(188, 45);
            this.tBarTgc3.TabIndex = 47;
            this.tBarTgc3.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tBarTgc3.Scroll += new System.EventHandler(this.tBarTgc3_Scroll);
            // 
            // trackBarRobotSpeed
            // 
            this.trackBarRobotSpeed.BackColor = System.Drawing.Color.Black;
            this.trackBarRobotSpeed.Location = new System.Drawing.Point(6, 201);
            this.trackBarRobotSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarRobotSpeed.Maximum = 100;
            this.trackBarRobotSpeed.Name = "trackBarRobotSpeed";
            this.trackBarRobotSpeed.Size = new System.Drawing.Size(187, 45);
            this.trackBarRobotSpeed.TabIndex = 53;
            this.trackBarRobotSpeed.TickFrequency = 5;
            this.trackBarRobotSpeed.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarRobotSpeed.Scroll += new System.EventHandler(this.trackBarRobotSpeed_Scroll);
            // 
            // panelLabel
            // 
            this.panelLabel.Controls.Add(this.labelImagesPer);
            this.panelLabel.Controls.Add(this.labelCompound);
            this.panelLabel.Controls.Add(this.labelSteering);
            this.panelLabel.Controls.Add(this.labelFocus);
            this.panelLabel.Controls.Add(this.labelFR);
            this.panelLabel.Controls.Add(this.labelDepth);
            this.panelLabel.Controls.Add(this.labelFrequency);
            this.panelLabel.Controls.Add(this.labelDynamic);
            this.panelLabel.Controls.Add(this.labelHighVolt);
            this.panelLabel.Controls.Add(this.labelMainGain);
            this.panelLabel.Location = new System.Drawing.Point(645, 37);
            this.panelLabel.Name = "panelLabel";
            this.panelLabel.Size = new System.Drawing.Size(140, 237);
            this.panelLabel.TabIndex = 47;
            // 
            // labelCompound
            // 
            this.labelCompound.AutoSize = true;
            this.labelCompound.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompound.Location = new System.Drawing.Point(3, 211);
            this.labelCompound.Name = "labelCompound";
            this.labelCompound.Size = new System.Drawing.Size(82, 16);
            this.labelCompound.TabIndex = 48;
            this.labelCompound.Text = "Compound";
            this.labelCompound.Visible = false;
            // 
            // labelSteering
            // 
            this.labelSteering.AutoSize = true;
            this.labelSteering.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSteering.Location = new System.Drawing.Point(3, 171);
            this.labelSteering.Name = "labelSteering";
            this.labelSteering.Size = new System.Drawing.Size(66, 16);
            this.labelSteering.TabIndex = 47;
            this.labelSteering.Text = "Steering";
            // 
            // labelFocus
            // 
            this.labelFocus.AutoSize = true;
            this.labelFocus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFocus.Location = new System.Drawing.Point(3, 150);
            this.labelFocus.Name = "labelFocus";
            this.labelFocus.Size = new System.Drawing.Size(50, 16);
            this.labelFocus.TabIndex = 46;
            this.labelFocus.Text = "Focus";
            // 
            // labelFR
            // 
            this.labelFR.AutoSize = true;
            this.labelFR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFR.Location = new System.Drawing.Point(3, 127);
            this.labelFR.Name = "labelFR";
            this.labelFR.Size = new System.Drawing.Size(28, 16);
            this.labelFR.TabIndex = 45;
            this.labelFR.Text = "FR";
            // 
            // cboxSCSize
            // 
            this.cboxSCSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxSCSize.FormattingEnabled = true;
            this.cboxSCSize.Location = new System.Drawing.Point(637, 494);
            this.cboxSCSize.Name = "cboxSCSize";
            this.cboxSCSize.Size = new System.Drawing.Size(158, 24);
            this.cboxSCSize.TabIndex = 48;
            this.cboxSCSize.SelectedIndexChanged += new System.EventHandler(this.cboxSCSize_SelectedIndexChanged);
            // 
            // panelSwitch
            // 
            this.panelSwitch.Controls.Add(this.butCfmMode);
            this.panelSwitch.Controls.Add(this.butRFMode);
            this.panelSwitch.Controls.Add(this.butDoubler);
            this.panelSwitch.Controls.Add(this.butCompound);
            this.panelSwitch.Controls.Add(this.buttonProbe1);
            this.panelSwitch.Location = new System.Drawing.Point(645, 290);
            this.panelSwitch.Name = "panelSwitch";
            this.panelSwitch.Size = new System.Drawing.Size(140, 184);
            this.panelSwitch.TabIndex = 49;
            // 
            // butCfmMode
            // 
            this.butCfmMode.BackColor = System.Drawing.Color.LightSteelBlue;
            this.butCfmMode.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCfmMode.ForeColor = System.Drawing.Color.Black;
            this.butCfmMode.Location = new System.Drawing.Point(6, 148);
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
            this.butRFMode.Location = new System.Drawing.Point(6, 115);
            this.butRFMode.Name = "butRFMode";
            this.butRFMode.Size = new System.Drawing.Size(131, 26);
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
            this.butDoubler.Location = new System.Drawing.Point(6, 83);
            this.butDoubler.Name = "butDoubler";
            this.butDoubler.Size = new System.Drawing.Size(131, 26);
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
            this.butCompound.Location = new System.Drawing.Point(7, 47);
            this.butCompound.Name = "butCompound";
            this.butCompound.Size = new System.Drawing.Size(131, 26);
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
            this.buttonProbe1.Location = new System.Drawing.Point(6, 10);
            this.buttonProbe1.Name = "buttonProbe1";
            this.buttonProbe1.Size = new System.Drawing.Size(131, 26);
            this.buttonProbe1.TabIndex = 47;
            this.buttonProbe1.Text = "Probe1";
            this.buttonProbe1.UseVisualStyleBackColor = false;
            this.buttonProbe1.Click += new System.EventHandler(this.buttonProbe1_Click);
            // 
            // gboxAngle
            // 
            this.gboxAngle.BackColor = System.Drawing.Color.Transparent;
            this.gboxAngle.Controls.Add(this.uctrlPMSteering);
            this.gboxAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxAngle.ForeColor = System.Drawing.Color.LightSlateGray;
            this.gboxAngle.Location = new System.Drawing.Point(583, 569);
            this.gboxAngle.Name = "gboxAngle";
            this.gboxAngle.Size = new System.Drawing.Size(75, 125);
            this.gboxAngle.TabIndex = 24;
            this.gboxAngle.TabStop = false;
            this.gboxAngle.Text = "Angle";
            // 
            // uctrlPMSteering
            // 
            this.uctrlPMSteering.BackColor = System.Drawing.Color.LightSteelBlue;
            this.uctrlPMSteering.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uctrlPMSteering.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uctrlPMSteering.ForeColor = System.Drawing.Color.Black;
            this.uctrlPMSteering.Location = new System.Drawing.Point(15, 17);
            this.uctrlPMSteering.Margin = new System.Windows.Forms.Padding(0);
            this.uctrlPMSteering.Name = "uctrlPMSteering";
            this.uctrlPMSteering.Size = new System.Drawing.Size(45, 100);
            this.uctrlPMSteering.TabIndex = 0;
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
            // gboxImagesPer
            // 
            this.gboxImagesPer.BackColor = System.Drawing.Color.Transparent;
            this.gboxImagesPer.Controls.Add(this.uctrlImagesPer);
            this.gboxImagesPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxImagesPer.ForeColor = System.Drawing.Color.LightSlateGray;
            this.gboxImagesPer.Location = new System.Drawing.Point(663, 569);
            this.gboxImagesPer.Name = "gboxImagesPer";
            this.gboxImagesPer.Size = new System.Drawing.Size(86, 125);
            this.gboxImagesPer.TabIndex = 25;
            this.gboxImagesPer.TabStop = false;
            this.gboxImagesPer.Text = "ImagesPer";
            // 
            // uctrlImagesPer
            // 
            this.uctrlImagesPer.BackColor = System.Drawing.Color.LightSteelBlue;
            this.uctrlImagesPer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uctrlImagesPer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uctrlImagesPer.ForeColor = System.Drawing.Color.Black;
            this.uctrlImagesPer.Location = new System.Drawing.Point(15, 17);
            this.uctrlImagesPer.Margin = new System.Windows.Forms.Padding(0);
            this.uctrlImagesPer.Name = "uctrlImagesPer";
            this.uctrlImagesPer.Size = new System.Drawing.Size(57, 100);
            this.uctrlImagesPer.TabIndex = 0;
            // 
            // gboxManual
            // 
            this.gboxManual.Controls.Add(this.trackBar1);
            this.gboxManual.Controls.Add(this.labelPosition);
            this.gboxManual.Controls.Add(this.butManFwd);
            this.gboxManual.Controls.Add(this.butManRev);
            this.gboxManual.Location = new System.Drawing.Point(805, 546);
            this.gboxManual.Margin = new System.Windows.Forms.Padding(2);
            this.gboxManual.Name = "gboxManual";
            this.gboxManual.Padding = new System.Windows.Forms.Padding(2);
            this.gboxManual.Size = new System.Drawing.Size(200, 118);
            this.gboxManual.TabIndex = 50;
            this.gboxManual.TabStop = false;
            this.gboxManual.Text = "Manual";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(9, 63);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(187, 45);
            this.trackBar1.TabIndex = 3;
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(78, 25);
            this.labelPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(44, 13);
            this.labelPosition.TabIndex = 2;
            this.labelPosition.Text = "Position";
            // 
            // butManFwd
            // 
            this.butManFwd.Location = new System.Drawing.Point(137, 14);
            this.butManFwd.Margin = new System.Windows.Forms.Padding(2);
            this.butManFwd.Name = "butManFwd";
            this.butManFwd.Size = new System.Drawing.Size(58, 36);
            this.butManFwd.TabIndex = 1;
            this.butManFwd.Text = "Forward";
            this.butManFwd.UseVisualStyleBackColor = true;
            this.butManFwd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.butManFwd_MouseDown);
            this.butManFwd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.butManFwd_MouseUp);
            // 
            // butManRev
            // 
            this.butManRev.Location = new System.Drawing.Point(9, 14);
            this.butManRev.Margin = new System.Windows.Forms.Padding(2);
            this.butManRev.Name = "butManRev";
            this.butManRev.Size = new System.Drawing.Size(58, 36);
            this.butManRev.TabIndex = 0;
            this.butManRev.Text = "Reverse";
            this.butManRev.UseVisualStyleBackColor = true;
            this.butManRev.MouseDown += new System.Windows.Forms.MouseEventHandler(this.butManRev_MouseDown);
            this.butManRev.MouseUp += new System.Windows.Forms.MouseEventHandler(this.butManRev_MouseUp);
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
            this.uctrlScan.Size = new System.Drawing.Size(512, 512);
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
            this.Controls.Add(this.gboxManual);
            this.Controls.Add(this.gBoxTgc);
            this.Controls.Add(this.gboxImage);
            this.Controls.Add(this.gboxGain);
            this.Controls.Add(this.gboxImagesPer);
            this.Controls.Add(this.gBoxImaging);
            this.Controls.Add(this.gboxAngle);
            this.Controls.Add(this.panelSwitch);
            this.Controls.Add(this.cboxSCSize);
            this.Controls.Add(this.panelLabel);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.uctrlGrayScale);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.gBoxCineloop);
            this.Controls.Add(this.gboxSave);
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
            this.gBoxImaging.ResumeLayout(false);
            this.gboxGain.ResumeLayout(false);
            this.gboxImage.ResumeLayout(false);
            this.gboxImage.PerformLayout();
            this.gboxSave.ResumeLayout(false);
            this.gBoxCineloop.ResumeLayout(false);
            this.gBoxCineloop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCine)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.gBoxTgc.ResumeLayout(false);
            this.gBoxTgc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBarTgc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarTgc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarTgc3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRobotSpeed)).EndInit();
            this.panelLabel.ResumeLayout(false);
            this.panelLabel.PerformLayout();
            this.panelSwitch.ResumeLayout(false);
            this.gboxAngle.ResumeLayout(false);
            this.gboxImagesPer.ResumeLayout(false);
            this.gboxManual.ResumeLayout(false);
            this.gboxManual.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControlScan uctrlScan;
        private System.Windows.Forms.Button buttonScan;
        public System.Windows.Forms.Label labelProbeName;
        private UserControlDepth uctrlDepth;
        private System.Windows.Forms.GroupBox gBoxImaging;
        private System.Windows.Forms.GroupBox gboxGain;
        private System.Windows.Forms.GroupBox gboxImage;
        private System.Windows.Forms.Button buttonZoomBox;
        private System.Windows.Forms.Label labelDepth;
        private System.Windows.Forms.Label labelFrequency;
        private System.Windows.Forms.Label labelImagesPer;
        private System.Windows.Forms.Label labelZoom;
        private System.Windows.Forms.GroupBox gboxSave;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelMainGain;
        private System.Windows.Forms.Label labelHighVolt;
        private System.Windows.Forms.GroupBox gBoxCineloop;
        private System.Windows.Forms.Button buttonCine;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.TrackBar trackBarCine;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Label labelDynamic;
        private System.Windows.Forms.GroupBox gBoxTgc;
        private System.Windows.Forms.TrackBar tBarTgc2;
        private System.Windows.Forms.TrackBar tBarTgc3;
        private System.Windows.Forms.TrackBar tBarTgc1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelFpga;
        private System.Windows.Forms.Label labelTgc2;
        private System.Windows.Forms.Label labelTgc1;
        private System.Windows.Forms.Label labelTgc3;
        private System.Windows.Forms.Panel panelLabel;
        private System.Windows.Forms.ComboBox cboxSCSize;
        private UserControlGrayScale uctrlGrayScale;
        private System.Windows.Forms.Panel panelSwitch;
        public System.Windows.Forms.Button buttonProbe1;
        private System.Windows.Forms.Label labelFR;
        private System.Windows.Forms.Label labelFocus;
        public System.Windows.Forms.Button butCompound;
        private System.Windows.Forms.Label labelSteering;
        public System.Windows.Forms.Button butDoubler;
        private System.Windows.Forms.Label labelCompound;
        private System.Windows.Forms.GroupBox gboxAngle;
        private UserControlPlusMinus uctrlPMDepth;
        private UserControlPlusMinus uctrlPMHighVoltage;
        private UserControlPlusMinus uctrlPMFocus;
        private UserControlPlusMinus userControlPlusMinus3;
        private UserControlPlusMinus uctrlPMFrequency;
        private UserControlPlusMinus uctrlPMDynamic;
        private UserControlPlusMinus uctrlPMGalGain;
        private UserControlPlusMinus uctrlPMSteering;
        public System.Windows.Forms.Button butRFMode;
        public System.Windows.Forms.Button butCfmMode;
        //UScanGuide 
        private System.Windows.Forms.Button buttonSaveCine;
        private System.Windows.Forms.Button buttonRobotScan;
        private System.Windows.Forms.Label labelRobotSpeed;
        private System.Windows.Forms.TrackBar trackBarRobotSpeed;
        public System.Windows.Forms.Button buttonProbe2; //not used
        private System.Windows.Forms.GroupBox gboxImagesPer;
        private UserControlPlusMinus uctrlImagesPer;
        private System.Windows.Forms.GroupBox gboxManual;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Button butManFwd;
        private System.Windows.Forms.Button butManRev;
    }
}

