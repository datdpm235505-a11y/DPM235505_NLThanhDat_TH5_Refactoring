using System;
using DPM235505_NLThanhDat_TH4_P14_IntroduceForeignMethod.After;
using DPM235505_NLThanhDat_TH4_P14_IntroduceForeignMethod.Real;

namespace DPM235505_NLThanhDat_TH4_P14_IntroduceForeignMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            new ReportRefactored().Process();

            Console.WriteLine("\n--- REAL ---");
            new TinhLuong().TinhNgayNhanLuong("Thành Đạt");

            Console.ReadLine();
        }
    }
}