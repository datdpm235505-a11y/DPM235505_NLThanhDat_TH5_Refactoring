using System;
using DPM235505_NLThanhDat_TH5_P31_MoveMethod.After;
using DPM235505_NLThanhDat_TH5_P31_MoveMethod.Real;

namespace DPM235505_NLThanhDat_TH5_P31_MoveMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            AccountRefactored acc = new AccountRefactored();
            acc.Type.IsPremium = true;
            acc.DaysOverdrawn = 10;
            Console.WriteLine("Phí thấu chi: " + acc.OverdraftCharge());

            Console.WriteLine("\n--- REAL ---");
            NhanVien nv = new NhanVien
            {
                TenNV = "Thành Đạt",
                LuongCoBan = 15000000,
                Phong = new PhongBan { TenPhong = "Phòng IT", HeSoPhuCap = 1.3 }
            };
            nv.InLuong();

            Console.ReadLine();
        }
    }
}