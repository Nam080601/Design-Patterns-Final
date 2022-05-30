using System;
using System.Data;
using System.Windows.Forms;
using Design_Patterns_Final.src.Provider;
using Design_Patterns_Final.src.SanPham;

namespace Design_Patterns_Final
{
    public partial class FormHoaDon : Form
    {
        DataTable dtOrders;

        public FormHoaDon()
        {
            InitializeComponent();
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
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

            // Calc Total
            double ThanhTien = 0;
            Product mainProduct = new Product();
            for (int i = 0; i < BillProvider.Instance.GetBill().Count; i++)
            {
                Product p = BillProvider.Instance.GetBill()[i];
                if (!p.IsTopping)
                {
                    mainProduct = p;
                    if (
                        i+1 == BillProvider.Instance.GetBill().Count ||
                        !BillProvider.Instance.GetBill()[i + 1].IsTopping
                        )
                    {
                        ThanhTien += mainProduct.ThanhTien();
                    }
                }
                else
                {
                    mainProduct = Deco(mainProduct, p.GetType().Name);
                    ThanhTien += mainProduct.ThanhTien();
                }
            }
            labelTongTien.Text = ThanhTien.ToString();
        }

        private Product Deco(Product p, string topping)
        {
            Product[] products = { new Bot(p), new Duong(p), new Sua(p) };
            foreach (Product product in products)
            {
                if (product.GetType().Name == topping)
                {
                    return product;
                }
            }
            return null;
        }
    }
}
