using System.Collections.Generic;
using Design_Patterns_Final.src.SanPham;

namespace Design_Patterns_Final.src.Provider
{
    internal class BillProvider
    {
        List<Product> bill = new List<Product>();
        private static BillProvider instance;
        public static BillProvider Instance
        {
            get { if (instance == null) instance = new BillProvider(); return instance; }
            private set { instance = value; }
        }
        private BillProvider() { }
        public List<Product> GetBill()
        {
            return bill;
        }
        public void AddItem(Product product)
        {
            bill.Add(product);
        }
        public void RemoveItem(int index)
        {
            bill.RemoveAt(index);
        }
    }
}
