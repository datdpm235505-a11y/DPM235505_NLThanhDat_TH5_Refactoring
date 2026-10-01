using System;
using DPM235505_NLThanhDat_TH4_P06_SplitTemporaryVariable.Before;
using DPM235505_NLThanhDat_TH4_P06_SplitTemporaryVariable.After;
using DPM235505_NLThanhDat_TH4_P06_SplitTemporaryVariable.Real;

namespace DPM235505_NLThanhDat_TH4_P06_SplitTemporaryVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- BEFORE (Chưa Refactor) ---");
            Geometry before = new Geometry();
            before.PrintGeometryDetails(5, 10);

            Console.WriteLine("\n--- AFTER (Đã Refactor - Tách biến tạm) ---");
            GeometryRefactored after = new GeometryRefactored();
            after.PrintGeometryDetails(5, 10);

            Console.WriteLine("\n--- REAL (Ứng dụng Quản lý Thu nhập Nhân viên) ---");
            NhanVienThuNhap nv = new NhanVienThuNhap();
            // Lương 500k/ngày, làm 24 ngày, thưởng 2 triệu
            nv.InThuNhap("Thành Đạt", 500000, 24, 2000000);

            Console.ReadLine();
        }
    }
}