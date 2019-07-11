namespace SDK_Example
{
    partial class FormProbes
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
            this.buttonOpen = new System.Windows.Forms.Button();
            this.cboxBoxProbes = new System.Windows.Forms.ComboBox();
            this.labelProbes = new System.Windows.Forms.Label();
            this.buttonIdle = new System.Windows.Forms.Button();
            this.lBoxMessage = new System.Windows.Forms.ListBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOpen
            // 
            this.buttonOpen.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpen.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.buttonOpen.Location = new System.Drawing.Point(45, 176);
            this.buttonOpen.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(100, 28);
            this.buttonOpen.TabIndex = 12;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = false;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpenClose_Click);
            // 
            // cboxBoxProbes
            // 
            this.cboxBoxProbes.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxBoxProbes.FormattingEnabled = true;
            this.cboxBoxProbes.Location = new System.Drawing.Point(45, 29);
            this.cboxBoxProbes.Margin = new System.Windows.Forms.Padding(4);
            this.cboxBoxProbes.Name = "cboxBoxProbes";
            this.cboxBoxProbes.Size = new System.Drawing.Size(423, 24);
            this.cboxBoxProbes.TabIndex = 10;
            // 
            // labelProbes
            // 
            this.labelProbes.AutoSize = true;
            this.labelProbes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProbes.Location = new System.Drawing.Point(45, 19);
            this.labelProbes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProbes.Name = "labelProbes";
            this.labelProbes.Size = new System.Drawing.Size(105, 16);
            this.labelProbes.TabIndex = 9;
            this.labelProbes.Text = "Detected Probes";
            // 
            // buttonIdle
            // 
            this.buttonIdle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonIdle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIdle.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.buttonIdle.Location = new System.Drawing.Point(207, 176);
            this.buttonIdle.Margin = new System.Windows.Forms.Padding(4);
            this.buttonIdle.Name = "buttonIdle";
            this.buttonIdle.Size = new System.Drawing.Size(100, 28);
            this.buttonIdle.TabIndex = 13;
            this.buttonIdle.Text = "Idle";
            this.buttonIdle.UseVisualStyleBackColor = false;
            this.buttonIdle.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // lBoxMessage
            // 
            this.lBoxMessage.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBoxMessage.FormattingEnabled = true;
            this.lBoxMessage.ItemHeight = 16;
            this.lBoxMessage.Location = new System.Drawing.Point(45, 71);
            this.lBoxMessage.Name = "lBoxMessage";
            this.lBoxMessage.Size = new System.Drawing.Size(424, 36);
            this.lBoxMessage.TabIndex = 14;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.Location = new System.Drawing.Point(45, 156);
            this.labelMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(61, 16);
            this.labelMessage.TabIndex = 15;
            this.labelMessage.Text = "Message";
            // 
            // buttonQuit
            // 
            this.buttonQuit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuit.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.buttonQuit.Location = new System.Drawing.Point(368, 176);
            this.buttonQuit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(100, 28);
            this.buttonQuit.TabIndex = 16;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = false;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // FormProbes
            // 
            this.AcceptButton = this.buttonOpen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.buttonIdle;
            this.ClientSize = new System.Drawing.Size(523, 235);
            this.ControlBox = false;
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.lBoxMessage);
            this.Controls.Add(this.buttonIdle);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.cboxBoxProbes);
            this.Controls.Add(this.labelProbes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProbes";
            this.Text = "FormProbes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.ComboBox cboxBoxProbes;
        private System.Windows.Forms.Label labelProbes;
        private System.Windows.Forms.Button buttonIdle;
        private System.Windows.Forms.ListBox lBoxMessage;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Button buttonQuit;
    }
}