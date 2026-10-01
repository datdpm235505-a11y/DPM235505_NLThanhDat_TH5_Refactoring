using System;
using DPM235505_NLThanhDat_TH4_P20_ReplaceErrorCodeWithException.After;
using DPM235505_NLThanhDat_TH4_P20_ReplaceErrorCodeWithException.Real;

namespace DPM235505_NLThanhDat_TH4_P20_ReplaceErrorCodeWithException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            AccountRefactored acc = new AccountRefactored();
            try
            {
                acc.Withdraw(1500); // Cố tình rút quá số dư
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bắt được lỗi: " + ex.Message);
            }

            Console.WriteLine("\n--- REAL ---");
            ATM atm = new ATM();
            try
            {
                atm.RutTien(6000000); // Thành Đạt thử rút 6 triệu
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}