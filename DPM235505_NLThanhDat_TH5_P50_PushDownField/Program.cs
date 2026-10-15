using System;
using DPM235505_NLThanhDat_TH5_P50_PushDownField.After;
using DPM235505_NLThanhDat_TH5_P50_PushDownField.Real;

namespace DPM235505_NLThanhDat_TH5_P50_PushDownField
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            Salesman sale = new Salesman { Quota = 100000 };
            Console.WriteLine("Chỉ tiêu của Sale: " + sale.Quota);

            Console.WriteLine("\n--- REAL ---");
            TaiKhoanTietKiem tkTK = new TaiKhoanTietKiem { ChuTaiKhoan = "Thành Đạt", SoDu = 50000000, LaiSuat = 6.5 };
            TaiKhoanThanhToan tkTT = new TaiKhoanThanhToan { ChuTaiKhoan = "Thành Đạt", SoDu = 2000000 };

            tkTK.InThongTin();
            tkTT.InThongTin();

            Console.ReadLine();
        }
    }
}