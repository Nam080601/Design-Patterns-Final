namespace Design_Patterns_Final.src.Payment
{
    abstract class PaymentFactory
    {
        public abstract PaymentProcess CreatePaymentProcess();

        public bool Handle(string otp)
        {
            PaymentProcess process = CreatePaymentProcess();
            return process.Handle(otp);
        }
        public void Notify(bool result)
        {
            PaymentProcess process = CreatePaymentProcess();
            process.Notify(result);
        }
    }
}
