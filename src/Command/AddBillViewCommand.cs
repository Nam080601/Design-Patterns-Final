using System.Data;

namespace Design_Patterns_Final.src.Command
{
    internal class AddBillViewCommand : ICommand
    {
        DataTable dt;
        public AddBillViewCommand(DataTable dt)
        {
            this.dt = dt;
        }
        public void Execute()
        {
            Bill.AddToView(ref dt);
        }
    }
}
