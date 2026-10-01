using System;

namespace DPM235505_NLThanhDat_TH4_P27_IntroduceNullObject.After
{
    public interface ICustomer
    {
        string GetPlan();
    }

    public class RealCustomer : ICustomer
    {
        public string GetPlan() => "Premium Plan";
    }

    // Đối tượng Null đại diện cho khách vãng lai, trả về giá trị mặc định
    public class NullCustomer : ICustomer
    {
        public string GetPlan() => "Basic Plan";
    }

    public class BillingRefactored
    {
        public void Process(ICustomer customer)
        {
            // Không cần check if(customer == null) nữa
            Console.WriteLine("Đang xử lý gói: " + customer.GetPlan());
        }
    }
}