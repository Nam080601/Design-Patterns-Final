﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Design_Patterns_Final.src;
using Design_Patterns_Final.src.DAO;

namespace Design_Patterns_Final
{
    public partial class FormCoffee : Form
    {
        public DataTable dtCoffees, dtOrders;
        List<Product> orders = new List<Product>();
        Product product;
        DataGridViewRow drRemove;
        public FormCoffee()
        {
            InitializeComponent();
        }

        private void FormCoffee_Load(object sender, EventArgs e)
        {
            // Fill data
            dtCoffees = new DataTable();
            dtCoffees.Columns.Add(new DataColumn("Mã Sản Phẩm"));
            dtCoffees.Columns.Add(new DataColumn("Tên Sản Phẩm"));
            dtCoffees.Columns.Add(new DataColumn("Giá"));

            foreach (Product p in ProductsDAO.Instance.GetAllProduct())
            {
                DataRow dr = dtCoffees.NewRow();

                dr["Mã Sản Phẩm"] = p.MaSanPham;
                dr["Tên Sản Phẩm"] = p.TenSanPham;
                dr["Giá"] = p.Gia;

                dtCoffees.Rows.Add(dr);
            }

            dataGridCoffee.DataSource = dtCoffees;

            // Create Column
            dtOrders = new DataTable();
            dtOrders.Columns.Add(new DataColumn("Tên Sản Phẩm"));
            dtOrders.Columns.Add(new DataColumn("Giá"));

            dataGridOrder.DataSource = dtOrders;
        }

        private void dataGridCoffee_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridCoffee.SelectedRows)
            {
                string masp = row.Cells[0].Value.ToString();
                product = ProductsDAO.Instance.GetProduct(masp);
            }
        }

        private void btnCoffeeThem_Click(object sender, EventArgs e)
        {
            orders.Add(product);
            dtOrders.Clear();

            // Fill Data
            foreach (Product p in orders)
            {
                DataRow dr = dtOrders.NewRow();

                dr["Tên Sản Phẩm"] = p.TenSanPham;
                dr["Giá"] = p.Gia;

                dtOrders.Rows.Add(dr);
            }
        }

        private void dataGridOrder_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridOrder.SelectedRows)
            {
                drRemove = row;
            }
        }

        private void btnCoffeeXoa_Click(object sender, EventArgs e)
        {
            try
            {
                orders.RemoveAt(drRemove.Index);
                dataGridOrder.Rows.RemoveAt(drRemove.Index);                
            } catch {
                MessageBox.Show("Không có gì trong hoá đơn để xoá", "Lỗi");
            }
        }
    }
}
