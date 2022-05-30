namespace Design_Patterns_Final.src.Payment
{
    internal class MomoFactory : PaymentFactory
    {
        public override PaymentProcess CreatePaymentProcess()
        {
            return new Momo();
        }
    }
}
