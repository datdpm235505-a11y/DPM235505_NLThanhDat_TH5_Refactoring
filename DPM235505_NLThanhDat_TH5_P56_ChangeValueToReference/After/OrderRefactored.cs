namespace DPM235505_NLThanhDat_TH5_P56_ChangeValueToReference.After
{
    public class OrderRefactored
    {
        public CustomerRefactored Customer { get; set; }

        public OrderRefactored(string customerName)
        {
            Customer = CustomerRepository.GetCustomer(customerName);
        }
    }
}