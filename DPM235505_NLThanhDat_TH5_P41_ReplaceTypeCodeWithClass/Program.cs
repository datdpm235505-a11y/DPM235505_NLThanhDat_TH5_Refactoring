using System;
using DPM235505_NLThanhDat_TH5_P41_ReplaceTypeCodeWithClass.After;
using DPM235505_NLThanhDat_TH5_P41_ReplaceTypeCodeWithClass.Real;

namespace DPM235505_NLThanhDat_TH5_P41_ReplaceTypeCodeWithClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            PersonRefactored p = new PersonRefactored { Name = "John", BloodGroup = BloodGroup.A };
            Console.WriteLine($"Tên: {p.Name}, Nhóm máu: {p.BloodGroup.GetName()}");

            Console.WriteLine("\n--- REAL ---");
            DonHang dh = new DonHang { MaDH = "DH_001", TrangThai = TrangThaiDonHang.DangGiao };
            dh.InDonHang();

            Console.ReadLine();
        }
    }
}