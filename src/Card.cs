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
        public string opt;
        public Boolean result = false;
        //public override void CheckOTP(string opt)
        //{
        //    this.opt = opt;
        //    Console.WriteLine("CheckOTP Card");
        //}
        public override void Handle(string otp)
        {
            if (opt == "1234")
            {
                this.result = true;
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
