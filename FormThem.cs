using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Design_Patterns_Final.src;
using Design_Patterns_Final.src.DAO;

namespace Design_Patterns_Final
{
    public partial class FormThem : Form
    {
        FormCoffee formCoffee;
        DataTable dtToppings, dtOrders;
        List<Product> orders;
        Product topping;
        DataGridViewRow drRemove;
        public FormThem(FormCoffee formCoffee)
        {
            this.formCoffee = formCoffee;
            InitializeComponent();
        }

        private void FormThem_Load(object sender, EventArgs e)
        {
            // Create column
            dtToppings = new DataTable();
            dtToppings.Columns.Add(new DataColumn("Mã Sản Phẩm"));
            dtToppings.Columns.Add(new DataColumn("Tên Sản Phẩm"));
            dtToppings.Columns.Add(new DataColumn("Giá"));

            // Fill topping data
            foreach (Product p in ToppingsDAO.Instance.GetAllTopping())
            {
                DataRow dr = dtToppings.NewRow();

                dr["Mã Sản Phẩm"] = p.MaSanPham;
                dr["Tên Sản Phẩm"] = p.TenSanPham;
                dr["Giá"] = p.Gia;

                dtToppings.Rows.Add(dr);
            }

            dataGridThem.DataSource = dtToppings;

            // Create Column
            dtOrders = new DataTable();
            dtOrders.Columns.Add(new DataColumn("Tên Sản Phẩm"));
            dtOrders.Columns.Add(new DataColumn("Giá"));

            dataGridOrder.DataSource = dtOrders;

            // Fill data from coffee bill
            for (int i = 0; i < formCoffee.dtOrders.Rows.Count; i++)
            {
                DataRow dr = dtOrders.NewRow();

                dr["Tên Sản Phẩm"] = formCoffee.dtOrders.Rows[i]["Tên Sản Phẩm"];
                dr["Giá"] = formCoffee.dtOrders.Rows[i]["Giá"];

                dtOrders.Rows.Add(dr);
            }

        }
        private void dataGridThem_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridThem.SelectedRows)
            {
                string masp = row.Cells[0].Value.ToString();
                topping = ToppingsDAO.Instance.GetTopping(masp);
            }
        }
        private void btnCoffeeThem_Click(object sender, EventArgs e)
        {
            orders.Add(topping);
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
            //
        }
        private void btnCoffeeXoa_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
