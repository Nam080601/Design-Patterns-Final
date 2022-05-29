﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Final.src
{
    internal class MomoFactory : PaymentFactory
    {
        public override PaymentProcess CreatePaymentProcess()
        {
            return new Momo();
        }
    }
}