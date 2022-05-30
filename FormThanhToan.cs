using System;
using System.Windows.Forms;
using Design_Patterns_Final.src.Command;
using Design_Patterns_Final.src.Payment;

namespace Design_Patterns_Final
{
    public partial class FormThanhToan : Form
    {
        PaymentContext context;
        CommandControl commandControl;
        public FormThanhToan()
        {
            InitializeComponent();
        }

        private void FormThanhToan_Load(object sender, EventArgs e)
        {
            context = new PaymentContext();
            commandControl = new CommandControl();
        }

        private void btnMomo_Click(object sender, EventArgs e)
        {            
            Form otp = new FormOTP("Momo");
            otp.Show();
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            Form otp = new FormOTP("Card");
            otp.Show();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            context.setPaymentStrategy(new CashFactory());
            context.Execute();
        }
    }
}
