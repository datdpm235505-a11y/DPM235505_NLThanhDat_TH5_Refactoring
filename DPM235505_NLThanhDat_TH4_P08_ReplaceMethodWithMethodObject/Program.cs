using System;
namespace DPM235505_NLThanhDat_TH4_P08_ReplaceMethodWithMethodObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("--- AFTER ---");
            After.Account acc = new After.Account();
            Console.WriteLine("Kết quả Gamma: " + acc.Gamma(10, 5, 2026));

            Console.WriteLine("\n--- REAL ---");
            new Real.NhanVienThuongTet().InThuongTet("Thành Đạt", 15000000, 12, 95);
            Console.ReadLine();
        }
    }
}