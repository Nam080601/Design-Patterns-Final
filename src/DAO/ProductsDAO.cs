using System;
using System.Collections.Generic;
using System.Data;
using Design_Patterns_Final.src.SanPham;

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
            List<Product> data = new List<Product>();
            string query = "SELECT * FROM dbo.SANPHAM";
            DataTable result = DB.Instance.ExecuteQuery(query);
            foreach (DataRow row in result.Rows)
            {
                Product product = new Product
                {
                    IsTopping = false,
                    MaSanPham = row["MASP"].ToString(),
                    TenSanPham = row["TENSP"].ToString(),
                    GiaSanPham = double.Parse(row["GIA"].ToString())
                };
                data.Add(product);
            }
            return data;
        }
        public Product GetProduct(string masanpham)
        {
            string query = "SELECT * FROM dbo.SANPHAM WHERE MASP = N'" + masanpham + "'";
            DataTable result = DB.Instance.ExecuteQuery(query);
            Product product = new Product
            {
                IsTopping = false,
                MaSanPham = result.Rows[0]["MASP"].ToString(),
                TenSanPham = result.Rows[0]["TENSP"].ToString(),
                GiaSanPham = double.Parse(result.Rows[0]["GIA"].ToString())
            };
            return product;
        }
    }
}
