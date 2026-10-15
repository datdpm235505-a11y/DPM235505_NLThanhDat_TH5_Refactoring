using System;
using DPM235505_NLThanhDat_TH5_P54_ReplaceExceptionWithTest.After;
using DPM235505_NLThanhDat_TH5_P54_ReplaceExceptionWithTest.Real;

namespace DPM235505_NLThanhDat_TH5_P54_ReplaceExceptionWithTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            ResourcePoolRefactored pool = new ResourcePoolRefactored();
            Console.WriteLine("Lấy tài nguyên: " + pool.GetResource());

            Console.WriteLine("\n--- REAL ---");
            HeThongDatVe rapPhim = new HeThongDatVe();
            rapPhim.MuaVe("Thành Đạt");
            rapPhim.MuaVe("Khách hàng B"); // Hết vé, hệ thống báo lỗi mượt mà không crash

            Console.ReadLine();
        }
    }
}