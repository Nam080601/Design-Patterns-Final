namespace Design_Patterns_Final
{
    partial class FormThem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelThem = new System.Windows.Forms.Panel();
            this.btnCoffeeXoa = new System.Windows.Forms.Button();
            this.labelCoffeeList = new System.Windows.Forms.Label();
            this.btnCoffeeThem = new System.Windows.Forms.Button();
            this.dataGridThem = new System.Windows.Forms.DataGridView();
            this.tHEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelBill = new System.Windows.Forms.Panel();
            this.labelOrder = new System.Windows.Forms.Label();
            this.dataGridOrder = new System.Windows.Forms.DataGridView();
            this.panelThem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridThem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHEMBindingSource)).BeginInit();
            this.panelBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // panelThem
            // 
            this.panelThem.Controls.Add(this.btnCoffeeXoa);
            this.panelThem.Controls.Add(this.labelCoffeeList);
            this.panelThem.Controls.Add(this.btnCoffeeThem);
            this.panelThem.Controls.Add(this.dataGridThem);
            this.panelThem.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelThem.Location = new System.Drawing.Point(0, 0);
            this.panelThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelThem.Name = "panelThem";
            this.panelThem.Size = new System.Drawing.Size(574, 646);
            this.panelThem.TabIndex = 0;
            // 
            // btnCoffeeXoa
            // 
            this.btnCoffeeXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnCoffeeXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoffeeXoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoffeeXoa.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCoffeeXoa.Location = new System.Drawing.Point(196, 574);
            this.btnCoffeeXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCoffeeXoa.Name = "btnCoffeeXoa";
            this.btnCoffeeXoa.Size = new System.Drawing.Size(150, 54);
            this.btnCoffeeXoa.TabIndex = 5;
            this.btnCoffeeXoa.Text = "XOÁ";
            this.btnCoffeeXoa.UseVisualStyleBackColor = false;
            this.btnCoffeeXoa.Click += new System.EventHandler(this.btnCoffeeXoa_Click);
            // 
            // labelCoffeeList
            // 
            this.labelCoffeeList.AutoSize = true;
            this.labelCoffeeList.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoffeeList.Location = new System.Drawing.Point(18, 14);
            this.labelCoffeeList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCoffeeList.Name = "labelCoffeeList";
            this.labelCoffeeList.Size = new System.Drawing.Size(315, 35);
            this.labelCoffeeList.TabIndex = 4;
            this.labelCoffeeList.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // btnCoffeeThem
            // 
            this.btnCoffeeThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnCoffeeThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoffeeThem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoffeeThem.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCoffeeThem.Location = new System.Drawing.Point(24, 574);
            this.btnCoffeeThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCoffeeThem.Name = "btnCoffeeThem";
            this.btnCoffeeThem.Size = new System.Drawing.Size(150, 54);
            this.btnCoffeeThem.TabIndex = 1;
            this.btnCoffeeThem.Text = "THÊM";
            this.btnCoffeeThem.UseVisualStyleBackColor = false;
            this.btnCoffeeThem.Click += new System.EventHandler(this.btnCoffeeThem_Click);
            // 
            // dataGridThem
            // 
            this.dataGridThem.AllowUserToAddRows = false;
            this.dataGridThem.AllowUserToDeleteRows = false;
            this.dataGridThem.AllowUserToResizeRows = false;
            this.dataGridThem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridThem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridThem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridThem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridThem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridThem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridThem.ColumnHeadersHeight = 30;
            this.dataGridThem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.dataGridThem.Location = new System.Drawing.Point(18, 55);
            this.dataGridThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridThem.Name = "dataGridThem";
            this.dataGridThem.ReadOnly = true;
            this.dataGridThem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridThem.RowHeadersVisible = false;
            this.dataGridThem.RowHeadersWidth = 62;
            this.dataGridThem.RowTemplate.Height = 30;
            this.dataGridThem.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridThem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridThem.Size = new System.Drawing.Size(543, 495);
            this.dataGridThem.TabIndex = 0;
            this.dataGridThem.SelectionChanged += new System.EventHandler(this.dataGridThem_SelectionChanged);
            // 
            // panelBill
            // 
            this.panelBill.Controls.Add(this.labelOrder);
            this.panelBill.Controls.Add(this.dataGridOrder);
            this.panelBill.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBill.Location = new System.Drawing.Point(574, 0);
            this.panelBill.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelBill.Name = "panelBill";
            this.panelBill.Size = new System.Drawing.Size(450, 646);
            this.panelBill.TabIndex = 2;
            // 
            // labelOrder
            // 
            this.labelOrder.AutoSize = true;
            this.labelOrder.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrder.Location = new System.Drawing.Point(9, 14);
            this.labelOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(143, 35);
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
            this.dataGridOrder.Location = new System.Drawing.Point(14, 55);
            this.dataGridOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridOrder.Name = "dataGridOrder";
            this.dataGridOrder.ReadOnly = true;
            this.dataGridOrder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridOrder.RowHeadersVisible = false;
            this.dataGridOrder.RowHeadersWidth = 62;
            this.dataGridOrder.RowTemplate.Height = 30;
            this.dataGridOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridOrder.Size = new System.Drawing.Size(418, 495);
            this.dataGridOrder.TabIndex = 1;
            this.dataGridOrder.SelectionChanged += new System.EventHandler(this.dataGridOrder_SelectionChanged);
            // 
            // FormThem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 646);
            this.Controls.Add(this.panelBill);
            this.Controls.Add(this.panelThem);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormThem";
            this.Text = "THEM";
            this.Load += new System.EventHandler(this.FormThem_Load);
            this.panelThem.ResumeLayout(false);
            this.panelThem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridThem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHEMBindingSource)).EndInit();
            this.panelBill.ResumeLayout(false);
            this.panelBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelThem;
        private System.Windows.Forms.Button btnCoffeeXoa;
        private System.Windows.Forms.Label labelCoffeeList;
        private System.Windows.Forms.Button btnCoffeeThem;
        private System.Windows.Forms.DataGridView dataGridThem;
        private System.Windows.Forms.BindingSource tHEMBindingSource;
        private System.Windows.Forms.Panel panelBill;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.DataGridView dataGridOrder;
    }
}