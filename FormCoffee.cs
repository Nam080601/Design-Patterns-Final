using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Design_Patterns_Final.src.DAO;
using Design_Patterns_Final.src.SanPham;
using Design_Patterns_Final.src.Provider;

namespace Design_Patterns_Final
{
    public partial class FormCoffee : Form
    {
        DataTable dtCoffees, dtOrders;
        Product product;
        DataGridViewRow drRemove;
        public FormCoffee()
        {
            InitializeComponent();
        }

        private void FormCoffee_Load(object sender, EventArgs e)
        {
            // Create Coffee Column
            dtCoffees = new DataTable();
            dtCoffees.Columns.Add(new DataColumn("Mã Sản Phẩm"));
            dtCoffees.Columns.Add(new DataColumn("Tên Sản Phẩm"));
            dtCoffees.Columns.Add(new DataColumn("Giá"));

            // Fill Coffee Data
            foreach (Product p in ProductsDAO.Instance.GetAllProduct())
            {
                DataRow dr = dtCoffees.NewRow();

                dr["Mã Sản Phẩm"] = p.MaSanPham;
                dr["Tên Sản Phẩm"] = p.TenSanPham;
                dr["Giá"] = p.GiaSanPham;

                dtCoffees.Rows.Add(dr);
            }

            dataGridCoffee.DataSource = dtCoffees;

            // Create Column
            dtOrders = new DataTable();
            dtOrders.Columns.Add(new DataColumn("Mã Sản Phẩm"));
            dtOrders.Columns.Add(new DataColumn("Tên Sản Phẩm"));
            dtOrders.Columns.Add(new DataColumn("Giá"));

            dataGridOrder.DataSource = dtOrders;

            // Fill Bill Data
            foreach (Product p in BillProvider.Instance.GetBill())
            {
                DataRow dr = dtOrders.NewRow();

                dr["Mã Sản Phẩm"] = p.MaSanPham;
                dr["Tên Sản Phẩm"] = p.TenSanPham;
                dr["Giá"] = p.GiaSanPham;

                dtOrders.Rows.Add(dr);
            }
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
            BillProvider.Instance.AddItem(product);

            DataRow dr = dtOrders.NewRow();

            dr["Mã Sản Phẩm"] = BillProvider.Instance.GetBill().LastOrDefault().MaSanPham;
            dr["Tên Sản Phẩm"] = BillProvider.Instance.GetBill().LastOrDefault().TenSanPham;
            dr["Giá"] = BillProvider.Instance.GetBill().LastOrDefault().GiaSanPham;

            dtOrders.Rows.Add(dr);
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
                BillProvider.Instance.RemoveItem(drRemove.Index);
                dataGridOrder.Rows.RemoveAt(drRemove.Index);
            }
            catch
            {
                MessageBox.Show("Không có gì trong hoá đơn để xoá", "Lỗi");
            }
        }
    }
}
