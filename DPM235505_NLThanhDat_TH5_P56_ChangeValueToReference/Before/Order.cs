namespace DPM235505_NLThanhDat_TH5_P56_ChangeValueToReference.Before
{
    public class Order
    {
        public Customer Customer { get; set; }

        // Mỗi lần tạo Order là tạo ra 1 object Customer mới, dù cùng tên
        public Order(string customerName)
        {
            Customer = new Customer(customerName);
        }
    }
}