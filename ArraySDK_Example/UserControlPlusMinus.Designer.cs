namespace SDK_Example
{
    partial class UserControlPlusMinus
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.butPlus = new System.Windows.Forms.Button();
            this.butMinus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoEllipsis = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(0, 43);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(60, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Nameabcd";
            // 
            // butPlus
            // 
            this.butPlus.BackColor = System.Drawing.Color.LightSteelBlue;
            this.butPlus.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.butPlus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPlus.Location = new System.Drawing.Point(5, 3);
            this.butPlus.Name = "butPlus";
            this.butPlus.Size = new System.Drawing.Size(33, 28);
            this.butPlus.TabIndex = 3;
            this.butPlus.Text = "+";
            this.butPlus.UseVisualStyleBackColor = false;
            this.butPlus.Click += new System.EventHandler(this.butPlus_Click);
            // 
            // butMinus
            // 
            this.butMinus.BackColor = System.Drawing.Color.LightSteelBlue;
            this.butMinus.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.butMinus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMinus.Location = new System.Drawing.Point(5, 65);
            this.butMinus.Name = "butMinus";
            this.butMinus.Size = new System.Drawing.Size(33, 28);
            this.butMinus.TabIndex = 4;
            this.butMinus.Text = "-";
            this.butMinus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.butMinus.UseVisualStyleBackColor = false;
            this.butMinus.Click += new System.EventHandler(this.butMinus_Click);
            // 
            // UserControlPlusMinus
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.butMinus);
            this.Controls.Add(this.butPlus);
            this.Controls.Add(this.labelName);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserControlPlusMinus";
            this.Size = new System.Drawing.Size(45, 100);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button butPlus;
        private System.Windows.Forms.Button butMinus;
    }
}
