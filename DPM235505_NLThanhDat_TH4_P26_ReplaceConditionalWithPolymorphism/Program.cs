using System;
using DPM235505_NLThanhDat_TH4_P26_ReplaceConditionalWithPolymorphism.After;
using DPM235505_NLThanhDat_TH4_P26_ReplaceConditionalWithPolymorphism.Real;

namespace DPM235505_NLThanhDat_TH4_P26_ReplaceConditionalWithPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            BirdRefactored bird = new AfricanBird(); // Tính đa hình
            Console.WriteLine("Tốc độ chim Châu Phi: " + bird.GetSpeed());

            Console.WriteLine("\n--- REAL ---");
            NhanVien nv1 = new NhanVienChinhThuc { Ten = "Thành Đạt" };
            NhanVien nv2 = new NhanVienThoiVu { Ten = "Sinh viên part-time" };

            Console.WriteLine($"{nv1.Ten} - Lương: {nv1.TinhLuong():N0} VNĐ");
            Console.WriteLine($"{nv2.Ten} - Lương: {nv2.TinhLuong():N0} VNĐ");

            Console.ReadLine();
        }
    }
}