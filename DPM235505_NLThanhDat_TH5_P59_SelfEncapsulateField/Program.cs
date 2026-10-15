using System;
using DPM235505_NLThanhDat_TH5_P59_SelfEncapsulateField.After;
using DPM235505_NLThanhDat_TH5_P59_SelfEncapsulateField.Real;

namespace DPM235505_NLThanhDat_TH5_P59_SelfEncapsulateField
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            IntRangeRefactored range = new IntRangeRefactored(1, 10);
            Console.WriteLine("Có chứa số 5 không? " + range.Includes(5));

            Console.WriteLine("\n--- REAL ---");
            GioHangVIP ghVip = new GioHangVIP();
            ghVip.ThemSP(1000000); // 1 triệu
            ghVip.InThanhToan(); // Vì là VIP nên hàm Getter tự giảm giá còn 900k

            Console.ReadLine();
        }
    }
}