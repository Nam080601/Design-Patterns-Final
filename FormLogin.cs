using System;
using System.Windows.Forms;
using Design_Patterns_Final.src;
using System.Data;

namespace Design_Patterns_Final
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            if (Login(username, password))
            {
                MessageBox.Show("Login successful", "Login");
            }
            else
            {
                MessageBox.Show("Login faild", "Login");
            }
        }
        // Accounts DAO
        public bool Login(string username, string password)
        {
            string query = "SELECT * FROM dbo.accounts WHERE taikhoan = N'" + username + "' AND matkhau = N'" + password + "' ";
            DataTable result = DB.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
    }
}
