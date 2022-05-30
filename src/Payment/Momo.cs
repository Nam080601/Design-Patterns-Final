using Design_Patterns_Final.src.Command;
using Design_Patterns_Final.src.Provider;
using System.Windows.Forms;

namespace Design_Patterns_Final.src.Payment
{
    internal class Momo : PaymentProcess
    {
        CommandControl commandControl = new CommandControl();
        public override bool Handle(string otp)
        {
            if (string.Equals(otp, "123456"))
            {
                OTPProvider.Instance.RemoveOTP();
                return true;
            }
            return false;

        }
        public override void Notify(bool result)
        {
            if (result)
            {
                MessageBox.Show("Payment successful", "Notify");
                // Clear bill view
                commandControl.SetCommand(new ClearBillViewCommand());
                commandControl.Execute();
            }
            else
            {
                MessageBox.Show("Incorrect OTP", "Notify");
            }
        }
    }
}
