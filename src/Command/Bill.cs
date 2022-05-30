using Design_Patterns_Final.src.Provider;
using Design_Patterns_Final.src.SanPham;
using System;
using System.Data;
using System.Linq;

namespace Design_Patterns_Final.src.Command
{
    static class Bill
    {
        public static void AddToBill(Product product)
        {
            BillProvider.Instance.AddItem(product);
        }

        public static void AddToView(ref DataTable dt)
        {
            DataRow dr = dt.NewRow();
            dr["Mã Sản Phẩm"] = BillProvider.Instance.GetBill().LastOrDefault().MaSanPham;
            dr["Tên Sản Phẩm"] = BillProvider.Instance.GetBill().LastOrDefault().TenSanPham;
            dr["Giá"] = BillProvider.Instance.GetBill().LastOrDefault().GiaSanPham;
            dt.Rows.Add(dr);
        }

        public static void ClearView()
        {
            BillProvider.Instance.RemoveAllItem();
        }
    }
}
