namespace Design_Patterns_Final.src.Payment
{
    abstract class PaymentProcess
    {
        
        public void Execute()
        {
            bool result = Handle();
            Notify(result);
        }   
        
        public abstract bool Handle(string opt="");
        public abstract void Notify(bool result);
    }
}
