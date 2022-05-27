using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Patterns_Final.src;

namespace Design_Patterns_Final.src.DAO
{
    internal class ProductsDAO
    {
        private static ProductsDAO instance;
        public static ProductsDAO Instance
        {
            get { if (instance == null) instance = new ProductsDAO(); return instance; }
            private set { instance = value; }
        }
        private ProductsDAO() { }
        public List<Product> GetAllProduct()
        {
            List<Product> list = new List<Product>();
            string query = "SELECT * FROM dbo.SANPHAM";
            DataTable result = DB.Instance.ExecuteQuery(query);

            for (int i = 0; i < result.Rows.Count; i++)
            {
                Product p = new Product(
                        result.Rows[i]["MASP"].ToString(),
                        result.Rows[i]["TENSP"].ToString(),
                        double.Parse(result.Rows[i]["GIA"].ToString())
                        );
                list.Add(p);

            }
            return list;
        }
        public Product GetProduct(string MaSanPham)
        {
            string query = "SELECT * FROM dbo.SANPHAM WHERE MASP = N'" + MaSanPham + "'";
            DataTable result = DB.Instance.ExecuteQuery(query);
            return
                new Product(
                    result.Rows[0]["MASP"].ToString(),
                    result.Rows[0]["TENSP"].ToString(),
                    double.Parse(result.Rows[0]["GIA"].ToString())
                    );
        }
    }
}
