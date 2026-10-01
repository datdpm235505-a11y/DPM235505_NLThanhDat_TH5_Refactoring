using System;
namespace DPM235505_NLThanhDat_TH4_P09_SubstituteAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string[] group = { "Alex", "Kent", "Bob" };
            Console.WriteLine("--- AFTER ---");
            Console.WriteLine("Tìm thấy: " + new After.PersonFinderRefactored().FoundPerson(group));

            Console.WriteLine("\n--- REAL ---");
            Real.KiemTraNhanVien kt = new Real.KiemTraNhanVien();
            kt.KiemTraNhanVienUuTu("Thành Đạt");
            kt.KiemTraNhanVienUuTu("Lê Văn C");
            Console.ReadLine();
        }
    }
}