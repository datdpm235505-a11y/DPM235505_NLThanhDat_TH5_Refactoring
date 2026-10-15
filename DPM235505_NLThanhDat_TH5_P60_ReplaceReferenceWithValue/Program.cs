using System;
using DPM235505_NLThanhDat_TH5_P60_ReplaceReferenceWithValue.After;
using DPM235505_NLThanhDat_TH5_P60_ReplaceReferenceWithValue.Real;

namespace DPM235505_NLThanhDat_TH5_P60_ReplaceReferenceWithValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            CurrencyRefactored usd1 = new CurrencyRefactored("USD");
            CurrencyRefactored usd2 = new CurrencyRefactored("USD");
            // Mặc dù là 2 object được new riêng biệt, nhưng vì là Value Object nên chúng BẰNG NHAU
            Console.WriteLine("So sánh 2 giá trị USD: " + usd1.Equals(usd2));

            Console.WriteLine("\n--- REAL ---");
            ToaDoGPS dhAG1 = new ToaDoGPS(10.3759, 105.4340); // Tọa độ ĐH An Giang
            ToaDoGPS dhAG2 = new ToaDoGPS(10.3759, 105.4340);

            // dhAG1.ViDo = 11.000; // Không thể gán, bảo vệ dữ liệu tuyệt đối
            Console.WriteLine("Hai tọa độ ĐHAG giống nhau không? " + dhAG1.Equals(dhAG2));

            Console.ReadLine();
        }
    }
}