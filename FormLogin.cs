using System;
using System.Windows.Forms;
using System.Data;
using Design_Patterns_Final.src.DAO;

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

            AccountDAO accountDAO = AccountDAO.Instance;

            if(username == "" || password == "")
            {
                MessageBox.Show("Username and password is required !", "Login");
            }
            else
            {
                if (accountDAO.Login(username, password))
                {
                    MessageBox.Show("Login successful !", "Login");
                    this.Hide();

                    FormMain formMain = new FormMain();
                    formMain.ShowDialog();

                    textBoxPassword.Clear();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect username or passowrd !", "Login");
                }
            }
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;
        }
    }
}
