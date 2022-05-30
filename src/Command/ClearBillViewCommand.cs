using System.Data;

namespace Design_Patterns_Final.src.Command
{
    internal class ClearBillViewCommand : ICommand
    {
        public void Execute()
        {
            Bill.ClearView();
        }
    }
}
