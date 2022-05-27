namespace Design_Patterns_Final
{
    partial class FormCoffee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelCoffee = new System.Windows.Forms.Panel();
            this.btnCoffeeXoa = new System.Windows.Forms.Button();
            this.labelCoffeeList = new System.Windows.Forms.Label();
            this.btnCoffeeThem = new System.Windows.Forms.Button();
            this.dataGridCoffee = new System.Windows.Forms.DataGridView();
            this.panelBill = new System.Windows.Forms.Panel();
            this.labelOrder = new System.Windows.Forms.Label();
            this.dataGridOrder = new System.Windows.Forms.DataGridView();
            this.panelCoffee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCoffee)).BeginInit();
            this.panelBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCoffee
            // 
            this.panelCoffee.Controls.Add(this.btnCoffeeXoa);
            this.panelCoffee.Controls.Add(this.labelCoffeeList);
            this.panelCoffee.Controls.Add(this.btnCoffeeThem);
            this.panelCoffee.Controls.Add(this.dataGridCoffee);
            this.panelCoffee.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCoffee.Location = new System.Drawing.Point(0, 0);
            this.panelCoffee.Name = "panelCoffee";
            this.panelCoffee.Size = new System.Drawing.Size(383, 420);
            this.panelCoffee.TabIndex = 0;
            // 
            // btnCoffeeXoa
            // 
            this.btnCoffeeXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnCoffeeXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoffeeXoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoffeeXoa.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCoffeeXoa.Location = new System.Drawing.Point(131, 373);
            this.btnCoffeeXoa.Name = "btnCoffeeXoa";
            this.btnCoffeeXoa.Size = new System.Drawing.Size(100, 35);
            this.btnCoffeeXoa.TabIndex = 5;
            this.btnCoffeeXoa.Text = "XOÁ";
            this.btnCoffeeXoa.UseVisualStyleBackColor = false;
            this.btnCoffeeXoa.Click += new System.EventHandler(this.btnCoffeeXoa_Click);
            // 
            // labelCoffeeList
            // 
            this.labelCoffeeList.AutoSize = true;
            this.labelCoffeeList.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoffeeList.Location = new System.Drawing.Point(12, 9);
            this.labelCoffeeList.Name = "labelCoffeeList";
            this.labelCoffeeList.Size = new System.Drawing.Size(208, 23);
            this.labelCoffeeList.TabIndex = 4;
            this.labelCoffeeList.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // btnCoffeeThem
            // 
            this.btnCoffeeThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnCoffeeThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoffeeThem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoffeeThem.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCoffeeThem.Location = new System.Drawing.Point(16, 373);
            this.btnCoffeeThem.Name = "btnCoffeeThem";
            this.btnCoffeeThem.Size = new System.Drawing.Size(100, 35);
            this.btnCoffeeThem.TabIndex = 1;
            this.btnCoffeeThem.Text = "THÊM";
            this.btnCoffeeThem.UseVisualStyleBackColor = false;
            this.btnCoffeeThem.Click += new System.EventHandler(this.btnCoffeeThem_Click);
            // 
            // dataGridCoffee
            // 
            this.dataGridCoffee.AllowUserToAddRows = false;
            this.dataGridCoffee.AllowUserToDeleteRows = false;
            this.dataGridCoffee.AllowUserToResizeColumns = false;
            this.dataGridCoffee.AllowUserToResizeRows = false;
            this.dataGridCoffee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridCoffee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCoffee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridCoffee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridCoffee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCoffee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridCoffee.ColumnHeadersHeight = 30;
            this.dataGridCoffee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.dataGridCoffee.Location = new System.Drawing.Point(12, 36);
            this.dataGridCoffee.Name = "dataGridCoffee";
            this.dataGridCoffee.ReadOnly = true;
            this.dataGridCoffee.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridCoffee.RowHeadersVisible = false;
            this.dataGridCoffee.RowTemplate.Height = 30;
            this.dataGridCoffee.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridCoffee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCoffee.Size = new System.Drawing.Size(362, 322);
            this.dataGridCoffee.TabIndex = 0;
            this.dataGridCoffee.SelectionChanged += new System.EventHandler(this.dataGridCoffee_SelectionChanged);
            // 
            // panelBill
            // 
            this.panelBill.Controls.Add(this.labelOrder);
            this.panelBill.Controls.Add(this.dataGridOrder);
            this.panelBill.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBill.Location = new System.Drawing.Point(383, 0);
            this.panelBill.Name = "panelBill";
            this.panelBill.Size = new System.Drawing.Size(300, 420);
            this.panelBill.TabIndex = 1;
            // 
            // labelOrder
            // 
            this.labelOrder.AutoSize = true;
            this.labelOrder.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrder.Location = new System.Drawing.Point(6, 9);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(93, 23);
            this.labelOrder.TabIndex = 5;
            this.labelOrder.Text = "HOÁ ĐƠN";
            // 
            // dataGridOrder
            // 
            this.dataGridOrder.AllowUserToAddRows = false;
            this.dataGridOrder.AllowUserToDeleteRows = false;
            this.dataGridOrder.AllowUserToResizeColumns = false;
            this.dataGridOrder.AllowUserToResizeRows = false;
            this.dataGridOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridOrder.ColumnHeadersHeight = 30;
            this.dataGridOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.dataGridOrder.Location = new System.Drawing.Point(9, 36);
            this.dataGridOrder.Name = "dataGridOrder";
            this.dataGridOrder.ReadOnly = true;
            this.dataGridOrder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridOrder.RowHeadersVisible = false;
            this.dataGridOrder.RowTemplate.Height = 30;
            this.dataGridOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridOrder.Size = new System.Drawing.Size(279, 322);
            this.dataGridOrder.TabIndex = 1;
            this.dataGridOrder.SelectionChanged += new System.EventHandler(this.dataGridOrder_SelectionChanged);
            // 
            // FormCoffee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 420);
            this.Controls.Add(this.panelBill);
            this.Controls.Add(this.panelCoffee);
            this.Name = "FormCoffee";
            this.Text = "SAN PHAM";
            this.Load += new System.EventHandler(this.FormCoffee_Load);
            this.panelCoffee.ResumeLayout(false);
            this.panelCoffee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCoffee)).EndInit();
            this.panelBill.ResumeLayout(false);
            this.panelBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCoffee;
        private System.Windows.Forms.Panel panelBill;
        private System.Windows.Forms.Label labelCoffeeList;
        private System.Windows.Forms.Button btnCoffeeThem;
        private System.Windows.Forms.DataGridView dataGridCoffee;
        private System.Windows.Forms.Button btnCoffeeXoa;
        private System.Windows.Forms.DataGridView dataGridOrder;
        private System.Windows.Forms.Label labelOrder;
    }
}