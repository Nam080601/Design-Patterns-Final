namespace Design_Patterns_Final
{
    partial class FormThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThanhToan));
            this.btnMomo = new System.Windows.Forms.Button();
            this.btnCard = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.labelMOMO = new System.Windows.Forms.Label();
            this.labelCARD = new System.Windows.Forms.Label();
            this.labelCASH = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMomo
            // 
            this.btnMomo.Image = ((System.Drawing.Image)(resources.GetObject("btnMomo.Image")));
            this.btnMomo.Location = new System.Drawing.Point(48, 110);
            this.btnMomo.Name = "btnMomo";
            this.btnMomo.Size = new System.Drawing.Size(150, 150);
            this.btnMomo.TabIndex = 0;
            this.btnMomo.UseVisualStyleBackColor = true;
            this.btnMomo.Click += new System.EventHandler(this.btnMomo_Click);
            // 
            // btnCard
            // 
            this.btnCard.Image = ((System.Drawing.Image)(resources.GetObject("btnCard.Image")));
            this.btnCard.Location = new System.Drawing.Point(268, 110);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(150, 150);
            this.btnCard.TabIndex = 1;
            this.btnCard.UseVisualStyleBackColor = true;
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // btnCash
            // 
            this.btnCash.Image = ((System.Drawing.Image)(resources.GetObject("btnCash.Image")));
            this.btnCash.Location = new System.Drawing.Point(489, 110);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(150, 150);
            this.btnCash.TabIndex = 2;
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // labelMOMO
            // 
            this.labelMOMO.AutoSize = true;
            this.labelMOMO.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMOMO.Location = new System.Drawing.Point(71, 276);
            this.labelMOMO.Name = "labelMOMO";
            this.labelMOMO.Size = new System.Drawing.Size(105, 33);
            this.labelMOMO.TabIndex = 3;
            this.labelMOMO.Text = "MOMO";
            // 
            // labelCARD
            // 
            this.labelCARD.AutoSize = true;
            this.labelCARD.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCARD.Location = new System.Drawing.Point(298, 276);
            this.labelCARD.Name = "labelCARD";
            this.labelCARD.Size = new System.Drawing.Size(91, 33);
            this.labelCARD.TabIndex = 4;
            this.labelCARD.Text = "CARD";
            // 
            // labelCASH
            // 
            this.labelCASH.AutoSize = true;
            this.labelCASH.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCASH.Location = new System.Drawing.Point(520, 276);
            this.labelCASH.Name = "labelCASH";
            this.labelCASH.Size = new System.Drawing.Size(89, 33);
            this.labelCASH.TabIndex = 5;
            this.labelCASH.Text = "CASH";
            // 
            // FormThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 420);
            this.Controls.Add(this.labelCASH);
            this.Controls.Add(this.labelCARD);
            this.Controls.Add(this.labelMOMO);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.btnCard);
            this.Controls.Add(this.btnMomo);
            this.Name = "FormThanhToan";
            this.Text = "THANH TOAN";
            this.Load += new System.EventHandler(this.FormThanhToan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMomo;
        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Label labelMOMO;
        private System.Windows.Forms.Label labelCARD;
        private System.Windows.Forms.Label labelCASH;
    }
}