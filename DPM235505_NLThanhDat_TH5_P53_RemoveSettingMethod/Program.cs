using System;
using DPM235505_NLThanhDat_TH5_P53_RemoveSettingMethod.After;
using DPM235505_NLThanhDat_TH5_P53_RemoveSettingMethod.Real;

namespace DPM235505_NLThanhDat_TH5_P53_RemoveSettingMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            AccountRefactored acc = new AccountRefactored("ACC_123");
            // acc.Id = "ACC_999"; // <- Lỗi ngay, bảo vệ dữ liệu cực tốt
            Console.WriteLine("ID Tài khoản: " + acc.Id);

            Console.WriteLine("\n--- REAL ---");
            HoaDon hd = new HoaDon("HD2026_001", 2500000);
            hd.InHoaDon();

            Console.ReadLine();
        }
    }
}