using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Final.src
{
    internal class Product
    {
        public string MaSanPham { get; }
        public string TenSanPham { get; }
        public double Gia { get; }
        public Product(string MaSanPham, string TenSanPham, double Gia)
        {
            this.MaSanPham = MaSanPham;
            this.TenSanPham = TenSanPham;
            this.Gia = Gia;
        }
    }
}
