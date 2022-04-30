using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Final.src.DAO
{
    internal class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }
        private AccountDAO() { }
        public bool Login(string username, string password)
        {
            string query = "SELECT * FROM dbo.accounts WHERE taikhoan = N'" + username + "' AND matkhau = N'" + password + "' ";
            DataTable result = DB.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
    }
}
