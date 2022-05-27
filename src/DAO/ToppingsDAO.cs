using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Patterns_Final.src;

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
            List<Product> list = new List<Product>();
            string query = "SELECT * FROM dbo.THEM";
            DataTable result = DB.Instance.ExecuteQuery(query);

            for (int i = 0; i < result.Rows.Count; i++)
            {
                Product t = new Product(
                        result.Rows[i]["MASPTHEM"].ToString(),
                        result.Rows[i]["TENSPTHEM"].ToString(),
                        double.Parse(result.Rows[i]["GIA"].ToString())
                        );
                list.Add(t);

            }
            return list;
        }
        public Product GetTopping(string MaSPThem)
        {
            string query = "SELECT * FROM dbo.THEM WHERE MASPTHEM = N'" + MaSPThem + "'";
            DataTable result = DB.Instance.ExecuteQuery(query);
            return
                new Product(
                    result.Rows[0]["MASPTHEM"].ToString(),
                    result.Rows[0]["TENSPTHEM"].ToString(),
                    double.Parse(result.Rows[0]["GIA"].ToString())
                    );
        }
    }
}
