﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Patterns_Final.src
{
    internal class Cash : PaymentProcess
    {
        public string opt;
        public Boolean result = false;
        //public override void CheckOTP(string otp)
        //{
        //    return;
        //}
        public override void Handle(string otp)
        {
             this.result = true;
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
