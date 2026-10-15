using System;
using DPM235505_NLThanhDat_TH5_P32_MoveField.After;
using DPM235505_NLThanhDat_TH5_P32_MoveField.Real;

namespace DPM235505_NLThanhDat_TH5_P32_MoveField
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            AccountRefactored acc = new AccountRefactored();
            acc.Type.InterestRate = 0.05;
            Console.WriteLine("Tiền lãi: " + acc.InterestForAmount(10000, 30));

            Console.WriteLine("\n--- REAL ---");
            NhanVien nv = new NhanVien
            {
                TenNV = "Thành Đạt",
                ChucVuNhanVien = new ChucVu { TenChucVu = "Trưởng phòng IT", PhuCapChucVu = 3000000 }
            };
            nv.InPhuCap();

            Console.ReadLine();
        }
    }
}