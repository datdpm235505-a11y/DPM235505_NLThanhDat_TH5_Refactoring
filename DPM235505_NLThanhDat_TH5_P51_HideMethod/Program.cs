using System;
using DPM235505_NLThanhDat_TH5_P51_HideMethod.After;
using DPM235505_NLThanhDat_TH5_P51_HideMethod.Real;

namespace DPM235505_NLThanhDat_TH5_P51_HideMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            CalculatorRefactored calc = new CalculatorRefactored();
            int[] nums = { 1, 2, 3, 4, 5 };
            // calc.Add(1, 2); // <- Giờ gõ dòng này sẽ báo lỗi, rất an toàn
            Console.WriteLine("Tổng: " + calc.CalculateTotal(nums));

            Console.WriteLine("\n--- REAL ---");
            MayPhaCaPhe may = new MayPhaCaPhe();
            may.PhaCaPhe(); // Khách chỉ có thể bấm nút PhaCaPhe()

            Console.ReadLine();
        }
    }
}