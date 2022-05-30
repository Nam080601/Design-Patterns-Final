using System;
using System.Windows.Forms;
using Design_Patterns_Final.src.Payment;
using Design_Patterns_Final.src.Provider;

namespace Design_Patterns_Final
{
    public partial class FormOTP : Form
    {
        PaymentContext context;
        string type = "";
        public FormOTP(string type)
        {
            InitializeComponent();
            this.type = type;
        }

        private void FormOTP_Load(object sender, EventArgs e)
        {
            context = new PaymentContext();
        }

        private void btnOTP_Click(object sender, EventArgs e)
        {
            bool isExec = false;
            OTPProvider.Instance.SetOTP(textBoxOTP.Text);
            PaymentFactory[] listPayment = { new MomoFactory(), new CardFactory() };
            foreach (PaymentFactory p in listPayment)
            {
                if (string.Equals(p.GetType().Name, type + "Factory", StringComparison.OrdinalIgnoreCase)) {
                    context.setPaymentStrategy(p);
                    context.Execute();                    
                    Hide();
                    isExec = true;
                }
            }
            if(!isExec)
            {
                MessageBox.Show("System Error", "Notify");
            }
        }
    }
}
