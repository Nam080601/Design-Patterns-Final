using Design_Patterns_Final.src.Provider;

namespace Design_Patterns_Final.src.Payment
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
            bool result = payment.Handle(OTPProvider.Instance.GetOTP());
            payment.Notify(result);
        }
    }
}
