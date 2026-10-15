using System;
using DPM235505_NLThanhDat_TH5_P46_SeparateQueryFromModifier.After;
using DPM235505_NLThanhDat_TH5_P46_SeparateQueryFromModifier.Real;

namespace DPM235505_NLThanhDat_TH5_P46_SeparateQueryFromModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            string[] list = { "Alice", "Don", "Bob" };
            SecurityRefactored sec = new SecurityRefactored();
            sec.SendAlert(list);
            Console.WriteLine("Tìm thấy: " + sec.FindMiscreant(list));

            Console.WriteLine("\n--- REAL ---");
            QuanLyKho kho = new QuanLyKho();
            kho.XuatKho(5);
            kho.XuatKho(10); // Cố tình xuất quá tồn kho

            Console.ReadLine();
        }
    }
}