using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Final.src
{
    internal class PaymentContext
    {
        private PaymentFactory payment;

        public void setPaymentStrategy(PaymentFactory payment)
        {
            this.payment = payment;
        }
        
        public void Execute()
        {
            payment.Handle();
            payment.Notify();
        }
    }
}
