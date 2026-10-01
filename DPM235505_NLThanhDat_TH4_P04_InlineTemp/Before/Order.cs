namespace DPM235505_NLThanhDat_TH4_P04_InlineTemp.Before
{
    public class Order
    {
        private double _basePrice;

        public Order(double basePrice)
        {
            _basePrice = basePrice;
        }

        public double BasePrice()
        {
            return _basePrice;
        }

        public bool HasDiscount()
        {
            // Biến tạm basePrice không mang lại nhiều giá trị giải thích
            double basePrice = BasePrice();
            return basePrice > 1000;
        }
    }
}