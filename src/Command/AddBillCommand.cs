using Design_Patterns_Final.src.SanPham;

namespace Design_Patterns_Final.src.Command
{
    internal class AddBillCommand : ICommand
    {
        Product product;
        public AddBillCommand(Product product)
        {
            this.product = product;
        }
        public void Execute()
        {
            Bill.AddToBill(product);
        }
    }
}
