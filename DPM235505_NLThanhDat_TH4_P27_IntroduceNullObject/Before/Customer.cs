using System;

namespace DPM235505_NLThanhDat_TH4_P27_IntroduceNullObject.Before
{
    public class Customer
    {
        public string Name { get; set; } = "";
        public string GetPlan() => "Premium Plan";
    }

    public class Billing
    {
        public void Process(Customer? customer)
        {
            // Phải check null, nếu không chương trình sẽ crash
            string plan;
            if (customer == null)
                plan = "Basic Plan"; // Mặc định cho người vô danh
            else
                plan = customer.GetPlan();

            Console.WriteLine("Đang xử lý gói: " + plan);
        }
    }
}