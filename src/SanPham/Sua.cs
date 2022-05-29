using Design_Patterns_Final.src.DAO;

namespace Design_Patterns_Final.src.SanPham
{
    class Sua : ProductDecorator
    {
        public Sua(Product product)
        {
            wrapper = product;
        }
        public override double ThanhTien()
        {
            return wrapper.GiaSanPham + ToppingsDAO.Instance.GetTopping("SUA").GiaSanPham;
        }
    }
}
