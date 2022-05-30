namespace Design_Patterns_Final.src.Payment
{
    internal class CardFactory : PaymentFactory
    {
        public override PaymentProcess CreatePaymentProcess()
        {
            return new Card();
        }
    }
}
