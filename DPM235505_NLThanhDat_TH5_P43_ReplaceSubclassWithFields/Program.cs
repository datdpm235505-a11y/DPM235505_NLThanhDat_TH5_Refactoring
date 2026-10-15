using System;
using DPM235505_NLThanhDat_TH5_P43_ReplaceSubclassWithFields.After;
using DPM235505_NLThanhDat_TH5_P43_ReplaceSubclassWithFields.Real;

namespace DPM235505_NLThanhDat_TH5_P43_ReplaceSubclassWithFields
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            PersonRefactored p = PersonRefactored.CreateMale();
            Console.WriteLine("Giới tính (Mã): " + p.GetCode());

            Console.WriteLine("\n--- REAL ---");
            GoiCuoc khachA = GoiCuoc.TaoGoiVip();
            GoiCuoc khachB = GoiCuoc.TaoGoiThuong();
            khachA.InThongTin();
            khachB.InThongTin();

            Console.ReadLine();
        }
    }
}