namespace DPM235505_NLThanhDat_TH5_P55_ReplaceDataValueWithObject.After
{
    public class OrderRefactored
    {
        // Sử dụng Đối tượng Customer thay vì String
        public Customer Customer { get; set; }

        public OrderRefactored(string customerName)
        {
            Customer = new Customer(customerName);
        }
    }
}