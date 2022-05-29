using System;
using System.Collections.Generic;
using System.Data;
using Design_Patterns_Final.src.SanPham;

namespace Design_Patterns_Final.src.DAO
{
    internal class ToppingsDAO
    {
        private static ToppingsDAO instance;
        public static ToppingsDAO Instance
        {
            get { if (instance == null) instance = new ToppingsDAO(); return instance; }
            private set { instance = value; }
        }
        private ToppingsDAO() { }
        public List<Product> GetAllTopping()
        {
            Product[] products = { new Bot(new Product()), new Duong(new Product()), new Sua(new Product()) };
            List<Product> data = new List<Product>();
            string query = "SELECT * FROM dbo.THEM";
            DataTable result = DB.Instance.ExecuteQuery(query);
            foreach (DataRow row in result.Rows)
            {
                foreach (Product product in products)
                {
                    if (string.Equals(row["MASPTHEM"].ToString(), product.GetType().Name, StringComparison.OrdinalIgnoreCase))
                    {
                        product.IsTopping = true;
                        product.MaSanPham = row["MASPTHEM"].ToString();
                        product.TenSanPham = row["TENSPTHEM"].ToString();
                        product.GiaSanPham = double.Parse(row["GIA"].ToString());
                        data.Add(product);
                    }
                }
            }
            return data;
        }
        public Product GetTopping(string masanpham)
        {
            Product[] products = { new Bot(new Product()), new Duong(new Product()), new Sua(new Product()) };
            string query = "SELECT * FROM dbo.THEM WHERE MASPTHEM = N'" + masanpham + "'";
            DataTable result = DB.Instance.ExecuteQuery(query);
            foreach (Product product in products)
            {
                if (string.Equals(masanpham, product.GetType().Name, StringComparison.OrdinalIgnoreCase))
                {
                    product.IsTopping = true;
                    product.MaSanPham = result.Rows[0]["MASPTHEM"].ToString();
                    product.TenSanPham = result.Rows[0]["TENSPTHEM"].ToString();
                    product.GiaSanPham = double.Parse(result.Rows[0]["GIA"].ToString());
                    return product;
                }
            }
            return null;
        }
    }
}
