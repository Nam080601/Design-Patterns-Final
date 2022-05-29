using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Patterns_Final.src
{
    internal class Card : PaymentProcess
    {
        public bool result = false;
        public override void Handle(string otp)
        {
            if (otp == "1234")
            {
                result = true;
            }

        }
        public override void Notify()
        {
            if (this.result)
            {
                MessageBox.Show("Success", "Notify");
            }
            MessageBox.Show("Faild", "Notify");
        }
    }
}
