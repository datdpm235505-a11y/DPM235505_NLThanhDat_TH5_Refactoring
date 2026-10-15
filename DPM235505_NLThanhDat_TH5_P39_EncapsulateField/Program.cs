using System;
using DPM235505_NLThanhDat_TH5_P39_EncapsulateField.After;
using DPM235505_NLThanhDat_TH5_P39_EncapsulateField.Real;

namespace DPM235505_NLThanhDat_TH5_P39_EncapsulateField
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            PersonRefactored p = new PersonRefactored();
            p.Name = ""; // Sẽ báo lỗi do bị chặn ở setter
            p.Name = "Alice";
            Console.WriteLine("Tên hợp lệ: " + p.Name);

            Console.WriteLine("\n--- REAL ---");
            TaiKhoanNganHang tk = new TaiKhoanNganHang { ChuTaiKhoan = "Thành Đạt" };
            // Không thể gán tk._soDu = 1000000; (Bảo mật cao)
            tk.NapTien(500000);

            Console.ReadLine();
        }
    }
}