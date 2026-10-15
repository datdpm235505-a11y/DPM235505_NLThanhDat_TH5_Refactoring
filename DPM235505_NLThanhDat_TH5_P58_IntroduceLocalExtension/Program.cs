using System;
using DPM235505_NLThanhDat_TH5_P58_IntroduceLocalExtension.After;
using DPM235505_NLThanhDat_TH5_P58_IntroduceLocalExtension.Real;

namespace DPM235505_NLThanhDat_TH5_P58_IntroduceLocalExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            ReportRefactored report = new ReportRefactored();
            report.Process();

            Console.WriteLine("\n--- REAL ---");
            HienThiGiaTien gia = new HienThiGiaTien();
            gia.InBaoGia();

            Console.ReadLine();
        }
    }
}