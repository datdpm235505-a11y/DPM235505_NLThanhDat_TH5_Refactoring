namespace DPM235505_NLThanhDat_TH4_P05_ReplaceTempWithQuery.Before
{
    public class Product
    {
        private int _quantity;
        private double _itemPrice;

        public Product(int quantity, double itemPrice)
        {
            _quantity = quantity;
            _itemPrice = itemPrice;
        }

        public double CalculateTotal()
        {
            // Biến tạm lưu trữ kết quả phép tính
            double basePrice = _quantity * _itemPrice;

            if (basePrice > 1000)
            {
                return basePrice * 0.95; // Giảm giá 5%
            }
            else
            {
                return basePrice * 0.98; // Giảm giá 2%
            }
        }
    }
}