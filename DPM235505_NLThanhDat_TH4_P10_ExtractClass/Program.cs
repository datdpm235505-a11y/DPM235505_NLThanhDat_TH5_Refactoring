using System;
namespace DPM235505_NLThanhDat_TH4_P10_ExtractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("--- AFTER ---");
            var p = new After.PersonRefactored { Name = "John" };
            p.OfficeTelephone.AreaCode = "028";
            p.OfficeTelephone.Number = "38123456";
            Console.WriteLine($"Name: {p.Name}, Phone: {p.OfficeTelephone.GetTelephoneNumber()}");

            Console.WriteLine("\n--- REAL ---");
            var nv = new Real.NhanVien { TenNV = "Thành Đạt" };
            nv.DiaChiNha.SoNha = "18";
            nv.DiaChiNha.Duong = "Ung Văn Khiêm";
            nv.DiaChiNha.ThanhPho = "Long Xuyên";
            nv.InThongTin();
            Console.ReadLine();
        }
    }
}