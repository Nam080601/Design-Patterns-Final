namespace Design_Patterns_Final.src.Payment
{
    internal class CashFactory : PaymentFactory
    {
        public override PaymentProcess CreatePaymentProcess()
        {
            return new Cash();
        }
    }
}
