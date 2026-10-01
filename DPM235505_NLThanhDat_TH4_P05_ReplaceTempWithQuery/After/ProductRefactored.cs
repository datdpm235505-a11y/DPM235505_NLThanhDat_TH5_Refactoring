namespace DPM235505_NLThanhDat_TH4_P05_ReplaceTempWithQuery.After
{
    public class ProductRefactored
    {
        private int _quantity;
        private double _itemPrice;

        public ProductRefactored(int quantity, double itemPrice)
        {
            _quantity = quantity;
            _itemPrice = itemPrice;
        }

        public double CalculateTotal()
        {
            // Thay thế biến tạm bằng cách gọi hàm truy vấn trực tiếp
            if (GetBasePrice() > 1000)
            {
                return GetBasePrice() * 0.95;
            }
            else
            {
                return GetBasePrice() * 0.98;
            }
        }

        // Tách biểu thức tính toán thành một hàm truy vấn riêng
        private double GetBasePrice()
        {
            return _quantity * _itemPrice;
        }
    }
}