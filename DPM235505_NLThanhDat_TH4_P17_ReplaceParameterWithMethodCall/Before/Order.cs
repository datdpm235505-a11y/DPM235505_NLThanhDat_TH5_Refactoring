namespace DPM235505_NLThanhDat_TH4_P17_ReplaceParameterWithMethodCall.Before
{
    public class Order
    {
        private int _quantity = 10;
        private double _itemPrice = 50.0;

        public double CalculatePrice()
        {
            double basePrice = _quantity * _itemPrice;
            double discountLevel = GetDiscountLevel();
            // Truyền discountLevel vào làm tham số
            return DiscountedPrice(basePrice, discountLevel);
        }

        private double GetDiscountLevel() => _quantity > 100 ? 0.1 : 0.05;

        private double DiscountedPrice(double basePrice, double discountLevel)
            => basePrice - (basePrice * discountLevel);
    }
}