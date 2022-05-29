namespace Design_Patterns_Final.src.SanPham
{
    public class Product
    {
        public bool IsTopping { get; set; }
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public double GiaSanPham { get; set; }
        public virtual double ThanhTien()
        {
            return GiaSanPham;
        }
    }
}
