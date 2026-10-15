using System;
using DPM235505_NLThanhDat_TH5_P34_ExtractInterface.After;
using DPM235505_NLThanhDat_TH5_P34_ExtractInterface.Real;

namespace DPM235505_NLThanhDat_TH5_P34_ExtractInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            IBillable billable = new EmployeeRefactored();
            Console.WriteLine("Mức phí dịch vụ: " + billable.GetChargeRate());

            Console.WriteLine("\n--- REAL ---");
            ITinhLuong nv1 = new NhanVienChinhThuc();
            ITinhLuong nv2 = new NhanVienThoiVu();

            Console.WriteLine($"Thành Đạt (Chính thức) thực lãnh: {nv1.TinhLuongThucLanh():N0} VNĐ");
            Console.WriteLine($"Nguyễn Văn B (Thời vụ) thực lãnh: {nv2.TinhLuongThucLanh():N0} VNĐ");

            Console.ReadLine();
        }
    }
}