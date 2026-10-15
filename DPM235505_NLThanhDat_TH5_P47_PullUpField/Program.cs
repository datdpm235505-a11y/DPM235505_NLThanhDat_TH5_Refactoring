using System;
using DPM235505_NLThanhDat_TH5_P47_PullUpField.After;
using DPM235505_NLThanhDat_TH5_P47_PullUpField.Real;

namespace DPM235505_NLThanhDat_TH5_P47_PullUpField
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            Engineer eng = new Engineer { Name = "John" };
            Console.WriteLine("Kỹ sư: " + eng.Name);

            Console.WriteLine("\n--- REAL ---");
            HocSinh hs = new HocSinh { HoTen = "Thành Đạt", CMND_CCCD = "089123456", TruongHoc = "ĐH An Giang" };
            Console.WriteLine($"Học sinh: {hs.HoTen} - Trường: {hs.TruongHoc}");

            Console.ReadLine();
        }
    }
}