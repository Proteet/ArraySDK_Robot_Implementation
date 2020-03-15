namespace ArraySDK_Example
{
    partial class FormCamera
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCameraDevices = new System.Windows.Forms.ComboBox();
            this.cmbCameraResolutions = new System.Windows.Forms.ComboBox();
            this.picCamera = new System.Windows.Forms.PictureBox();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCamera)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cameras: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resolutions: ";
            // 
            // cmbCameraDevices
            // 
            this.cmbCameraDevices.FormattingEnabled = true;
            this.cmbCameraDevices.Location = new System.Drawing.Point(88, 6);
            this.cmbCameraDevices.Name = "cmbCameraDevices";
            this.cmbCameraDevices.Size = new System.Drawing.Size(121, 21);
            this.cmbCameraDevices.TabIndex = 2;
            this.cmbCameraDevices.SelectedIndexChanged += new System.EventHandler(this.CmbCameraDevices_SelectedIndexChanged);
            // 
            // cmbCameraResolutions
            // 
            this.cmbCameraResolutions.FormattingEnabled = true;
            this.cmbCameraResolutions.Location = new System.Drawing.Point(87, 34);
            this.cmbCameraResolutions.Name = "cmbCameraResolutions";
            this.cmbCameraResolutions.Size = new System.Drawing.Size(121, 21);
            this.cmbCameraResolutions.TabIndex = 3;
            this.cmbCameraResolutions.SelectedIndexChanged += new System.EventHandler(this.CmbCameraResolutions_SelectedIndexChanged);
            // 
            // picCamera
            // 
            this.picCamera.Location = new System.Drawing.Point(15, 76);
            this.picCamera.Name = "picCamera";
            this.picCamera.Size = new System.Drawing.Size(284, 303);
            this.picCamera.TabIndex = 4;
            this.picCamera.TabStop = false;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(120, 415);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // FormCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 450);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.picCamera);
            this.Controls.Add(this.cmbCameraResolutions);
            this.Controls.Add(this.cmbCameraDevices);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCamera";
            this.Text = "FormCamera";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCamera_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picCamera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCameraDevices;
        private System.Windows.Forms.ComboBox cmbCameraResolutions;
        private System.Windows.Forms.PictureBox picCamera;
        private System.Windows.Forms.Button buttonSave;
    }
}