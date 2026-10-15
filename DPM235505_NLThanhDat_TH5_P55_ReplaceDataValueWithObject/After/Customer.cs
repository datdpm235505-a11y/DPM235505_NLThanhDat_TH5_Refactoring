namespace DPM235505_NLThanhDat_TH5_P55_ReplaceDataValueWithObject.After
{
    // Nâng cấp thành một Đối tượng đàng hoàng
    public class Customer
    {
        public string Name { get; set; } = "";
        public string PhoneNumber { get; set; } = "";

        public Customer(string name)
        {
            Name = name;
        }
    }
}