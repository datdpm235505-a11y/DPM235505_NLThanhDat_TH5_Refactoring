using System;
using DPM235505_NLThanhDat_TH4_P28_RenameMethod.After;
using DPM235505_NLThanhDat_TH4_P28_RenameMethod.Real;

namespace DPM235505_NLThanhDat_TH4_P28_RenameMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            CustomerRefactored cus = new CustomerRefactored { Name = "John Doe" };
            Console.WriteLine("Tên khách hàng: " + cus.GetName());

            Console.WriteLine("\n--- REAL ---");
            ChamCong cc = new ChamCong();
            cc.InBaoCao("Thành Đạt", 22, 2);

            Console.ReadLine();
        }
    }
}