using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Design_Patterns_Final.src.DAO;
using Design_Patterns_Final.src.SanPham;
using Design_Patterns_Final.src.Provider;
using Design_Patterns_Final.src.Command;

namespace Design_Patterns_Final
{
    public partial class FormCoffee : Form
    {
        DataTable dtCoffees, dtOrders;
        Product product;
        DataGridViewRow drRemove;
        CommandControl commandControl;
        public FormCoffee()
        {
            InitializeComponent();
        }

        private void FormCoffee_Load(object sender, EventArgs e)
        {
            // Create command
            commandControl = new CommandControl();
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
            // Call command add product to bill
            commandControl.SetCommand(new AddBillCommand(product));
            commandControl.Execute();

            // Call command add product to view
            commandControl.SetCommand(new AddBillViewCommand(dtOrders));
            commandControl.Execute();
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
