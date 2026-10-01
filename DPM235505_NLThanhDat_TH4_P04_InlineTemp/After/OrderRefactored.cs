namespace DPM235505_NLThanhDat_TH4_P04_InlineTemp.After
{
    public class OrderRefactored
    {
        private double _basePrice;

        public OrderRefactored(double basePrice)
        {
            _basePrice = basePrice;
        }

        public double BasePrice()
        {
            return _basePrice;
        }

        public bool HasDiscount()
        {
            // Đã gộp (inline) trực tiếp, code ngắn gọn hơn
            return BasePrice() > 1000;
        }
    }
}