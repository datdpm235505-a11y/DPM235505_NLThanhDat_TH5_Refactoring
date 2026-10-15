using System;
using DPM235505_NLThanhDat_TH5_P57_FormTemplateMethod.After;
using DPM235505_NLThanhDat_TH5_P57_FormTemplateMethod.Real;

namespace DPM235505_NLThanhDat_TH5_P57_FormTemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            CoffeeRefactored coffee = new CoffeeRefactored();
            coffee.PrepareRecipe();

            Console.WriteLine("\n--- REAL ---");
            QuyTrinhKiemThu uiTest = new KiemThuGiaoDien();
            uiTest.ChayKiemThu();

            QuyTrinhKiemThu securityTest = new KiemThuBaoMat();
            securityTest.ChayKiemThu();

            Console.ReadLine();
        }
    }
}