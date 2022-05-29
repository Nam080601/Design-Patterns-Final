using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Design_Patterns_Final.src;
using Design_Patterns_Final.src.DAO;
using Design_Patterns_Final.src.SanPham;

namespace Design_Patterns_Final
{
    public partial class FormThem : Form
    {
        DataTable dtToppings, dtOrders;
        Product topping;
        DataGridViewRow drRemove;
        public FormThem()
        {
            InitializeComponent();
        }

        private void FormThem_Load(object sender, EventArgs e)
        {
            // Create Topping Column
            dtToppings = new DataTable();
            dtToppings.Columns.Add(new DataColumn("Mã Sản Phẩm"));
            dtToppings.Columns.Add(new DataColumn("Tên Sản Phẩm"));
            dtToppings.Columns.Add(new DataColumn("Giá"));

            // Fill Topping data
            foreach (Product p in ToppingsDAO.Instance.GetAllTopping())
            {
                DataRow dr = dtToppings.NewRow();

                dr["Mã Sản Phẩm"] = p.MaSanPham;
                dr["Tên Sản Phẩm"] = p.TenSanPham;
                dr["Giá"] = p.GiaSanPham;

                dtToppings.Rows.Add(dr);
            }

            dataGridThem.DataSource = dtToppings;

            // Create Bill Column
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
            BillProvider.Instance.AddItem(topping);

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
                if (drRemove == null)
                {
                    MessageBox.Show("Không có gì trong hoá đơn để xoá", "Lỗi");
                    return;
                }
                BillProvider.Instance.RemoveItem(BillProvider.Instance.GetBill().Count - 1 + drRemove.Index);
                dataGridOrder.Rows.RemoveAt(BillProvider.Instance.GetBill().Count - 1 + drRemove.Index);
            }
            catch
            {
                MessageBox.Show("Lỗi !", "Lỗi");
            }
        }
    }
}
