namespace Design_Patterns_Final
{
    partial class FormOTP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOTP));
            this.labelOTP = new System.Windows.Forms.Label();
            this.btnOTP = new System.Windows.Forms.Button();
            this.textBoxOTP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelOTP
            // 
            this.labelOTP.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelOTP.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOTP.Location = new System.Drawing.Point(0, 0);
            this.labelOTP.Name = "labelOTP";
            this.labelOTP.Size = new System.Drawing.Size(378, 97);
            this.labelOTP.TabIndex = 0;
            this.labelOTP.Text = "Nhap OTP";
            this.labelOTP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOTP
            // 
            this.btnOTP.Location = new System.Drawing.Point(150, 170);
            this.btnOTP.Name = "btnOTP";
            this.btnOTP.Size = new System.Drawing.Size(75, 50);
            this.btnOTP.TabIndex = 1;
            this.btnOTP.Text = "OK";
            this.btnOTP.UseVisualStyleBackColor = true;
            this.btnOTP.Click += new System.EventHandler(this.btnOTP_Click);
            // 
            // textBoxOTP
            // 
            this.textBoxOTP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOTP.Location = new System.Drawing.Point(115, 100);
            this.textBoxOTP.Name = "textBoxOTP";
            this.textBoxOTP.Size = new System.Drawing.Size(150, 39);
            this.textBoxOTP.TabIndex = 2;
            this.textBoxOTP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormOTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 244);
            this.Controls.Add(this.textBoxOTP);
            this.Controls.Add(this.btnOTP);
            this.Controls.Add(this.labelOTP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOTP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OTP";
            this.Load += new System.EventHandler(this.FormOTP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOTP;
        private System.Windows.Forms.Button btnOTP;
        private System.Windows.Forms.TextBox textBoxOTP;
    }
}