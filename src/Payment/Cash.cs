using Design_Patterns_Final.src.Command;
using System.Windows.Forms;

namespace Design_Patterns_Final.src.Payment
{
    internal class Cash : PaymentProcess
    {
        CommandControl commandControl = new CommandControl();
        public override bool Handle(string otp = "")
        {
            if (string.Equals(otp, ""))
                return true;
            return false;
        }
        public override void Notify(bool result)
        {
            if (result)
            {
                MessageBox.Show("Payment Successfull", "Notify");
                // Clear bill view
                commandControl.SetCommand(new ClearBillViewCommand());
                commandControl.Execute();
            }
            else
            {
                MessageBox.Show("Failed", "Notify");
            }
        }
    }
}
