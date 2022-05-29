using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Final.src
{
    abstract class PaymentProcess
    {
        
        public void Execute()
        {
            Handle();
            Notify();
        }   
        
        public abstract void Handle(string opt="");
        public abstract void Notify();
    }
}
