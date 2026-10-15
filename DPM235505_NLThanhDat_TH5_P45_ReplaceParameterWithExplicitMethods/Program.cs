using System;
using DPM235505_NLThanhDat_TH5_P45_ReplaceParameterWithExplicitMethods.After;
using DPM235505_NLThanhDat_TH5_P45_ReplaceParameterWithExplicitMethods.Real;

namespace DPM235505_NLThanhDat_TH5_P45_ReplaceParameterWithExplicitMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            ShapeRefactored shape = new ShapeRefactored();
            shape.SetHeight(10);
            shape.SetWidth(20);
            Console.WriteLine($"Kích thước: {shape.Width}x{shape.Height}");

            Console.WriteLine("\n--- REAL ---");
            // Đã sửa lại thành new HeThongDen();
            HeThongDen den = new HeThongDen();
            den.BatDenNgu();
            den.TatDenNgu();

            Console.ReadLine();
        }
    }
}