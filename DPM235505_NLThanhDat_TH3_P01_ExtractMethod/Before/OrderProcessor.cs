using System;

namespace DPM235505_NLThanhDat_TH4_P01_ExtractMethod.Before
{
    public class OrderProcessor
    {
        public void PrintOwing(string name, double amount)
        {
            // 1. In tiêu đề (Banner)
            Console.WriteLine("*****************************");
            Console.WriteLine("**** Customer Owes ****");
            Console.WriteLine("*****************************");

            // 2. Tính toán
            double outstanding = amount * 1.1; // Tính thêm 10% thuế

            // 3. In chi tiết
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Amount: " + outstanding);
        }
    }
}