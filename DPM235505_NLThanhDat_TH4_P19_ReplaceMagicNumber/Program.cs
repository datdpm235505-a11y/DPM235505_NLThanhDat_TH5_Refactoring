using System;
using DPM235505_NLThanhDat_TH4_P19_ReplaceMagicNumber.After;
using DPM235505_NLThanhDat_TH4_P19_ReplaceMagicNumber.Real;

namespace DPM235505_NLThanhDat_TH4_P19_ReplaceMagicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            PhysicsRefactored phys = new PhysicsRefactored();
            Console.WriteLine($"Thế năng (mass 10, height 5): {phys.PotentialEnergy(10, 5)} J");

            Console.WriteLine("\n--- REAL ---");
            TinhLuongLamThem tl = new TinhLuongLamThem();
            tl.InLuongNgayLe("Thành Đạt", 500000);

            Console.ReadLine();
        }
    }
}