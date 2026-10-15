using System;

namespace DPM235505_NLThanhDat_TH5_P55_ReplaceDataValueWithObject.Before
{
    public class Order
    {
        // Khách hàng chỉ là một chuỗi String (Bad smell khi sau này cần lưu thêm SĐT, Địa chỉ)
        public string CustomerName { get; set; } = "";

        public Order(string customerName)
        {
            CustomerName = customerName;
        }
    }
}