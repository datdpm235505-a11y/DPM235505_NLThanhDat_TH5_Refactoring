using System.Collections.Generic;

namespace DPM235505_NLThanhDat_TH5_P56_ChangeValueToReference.After
{
    // Nơi lưu trữ dùng chung để biến Value thành Reference
    public static class CustomerRepository
    {
        private static Dictionary<string, CustomerRefactored> _instances = new Dictionary<string, CustomerRefactored>();

        public static CustomerRefactored GetCustomer(string name)
        {
            if (!_instances.ContainsKey(name))
                _instances[name] = new CustomerRefactored(name); // Chỉ tạo 1 lần

            return _instances[name]; // Trả về tham chiếu dùng chung
        }
    }
}