using System.Windows.Forms;

namespace Design_Patterns_Final.src.Payment
{
    internal class Card : PaymentProcess
    {
        public override bool Handle(string otp)
        {
            if (string.Equals(otp, "1234"))
            {
                return true;
            }
            return false;

        }
        public override void Notify(bool result)
        {
            if (result)
            {
                MessageBox.Show("Success", "Notify");
            }
            else
            {
                MessageBox.Show("Failed", "Notify");
            }
        }
    }
}
