namespace DPM235505_NLThanhDat_TH4_P17_ReplaceParameterWithMethodCall.After
{
    public class OrderRefactored
    {
        private int _quantity = 10;
        private double _itemPrice = 50.0;

        public double CalculatePrice()
        {
            double basePrice = _quantity * _itemPrice;
            // Bỏ tham số discountLevel đi, gọi trực tiếp bên trong hàm
            return DiscountedPrice(basePrice);
        }

        private double GetDiscountLevel() => _quantity > 100 ? 0.1 : 0.05;

        private double DiscountedPrice(double basePrice)
            => basePrice - (basePrice * GetDiscountLevel()); // Gọi hàm tại đây
    }
}