using System;
using System.Windows.Forms;

namespace Design_Patterns_Final.src.Payment
{
    internal class Momo : PaymentProcess
    {
        public override bool Handle(string otp)
        {
            if (string.Equals(otp, "123456"))
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
