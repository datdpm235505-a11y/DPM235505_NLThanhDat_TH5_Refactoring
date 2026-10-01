using System;
using DPM235505_NLThanhDat_TH4_P22_ConsolidateConditionalExpression.After;
using DPM235505_NLThanhDat_TH4_P22_ConsolidateConditionalExpression.Real;

namespace DPM235505_NLThanhDat_TH4_P22_ConsolidateConditionalExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            DisabilityRefactored calc = new DisabilityRefactored();
            Console.WriteLine("Tiền trợ cấp: " + calc.DisabilityAmount());

            Console.WriteLine("\n--- REAL ---");
            XetDuyetKhoanVay nganHang = new XetDuyetKhoanVay();
            nganHang.KiemTraVayVon("Thành Đạt", 20, 15000000, false); // Đủ điều kiện
            nganHang.KiemTraVayVon("Nguyễn Văn A", 17, 10000000, false); // Tuổi nhỏ

            Console.ReadLine();
        }
    }
}