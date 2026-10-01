using System;
using DPM235505_NLThanhDat_TH4_P24_RemoveControlFlag.After;
using DPM235505_NLThanhDat_TH4_P24_RemoveControlFlag.Real;

namespace DPM235505_NLThanhDat_TH4_P24_RemoveControlFlag
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            SearcherRefactored searcher = new SearcherRefactored();
            searcher.CheckSecurity(new string[] { "Alice", "Don", "Bob" });

            Console.WriteLine("\n--- REAL ---");
            TimKiemNhanVien tk = new TimKiemNhanVien();
            string[] ds = { "Nguyễn A", "Lê B", "Thành Đạt", "Trần C" };
            tk.TimNhanVienXuatSac(ds);

            Console.ReadLine();
        }
    }
}