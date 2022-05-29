using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Final.src
{
    abstract class PaymentFactory
    {
        public abstract PaymentProcess CreatePaymentProcess();

        public void Handle(string otp="")
        {
            PaymentProcess process = CreatePaymentProcess();
            process.Handle(otp);
        }
        public void Notify()
        {
            PaymentProcess process = CreatePaymentProcess();
            process.Notify();
        }
    }
}
