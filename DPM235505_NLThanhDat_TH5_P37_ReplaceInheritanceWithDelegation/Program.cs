using System;
using DPM235505_NLThanhDat_TH5_P37_ReplaceInheritanceWithDelegation.After;
using DPM235505_NLThanhDat_TH5_P37_ReplaceInheritanceWithDelegation.Real;

namespace DPM235505_NLThanhDat_TH5_P37_ReplaceInheritanceWithDelegation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            MyStackRefactored stack = new MyStackRefactored();
            Console.WriteLine("Ngăn xếp có trống không? " + stack.IsEmpty());

            Console.WriteLine("\n--- REAL ---");
            DonHang dh = new DonHang();
            dh.XuLyDonHang("Thành Đạt", 500000);

            Console.ReadLine();
        }
    }
}