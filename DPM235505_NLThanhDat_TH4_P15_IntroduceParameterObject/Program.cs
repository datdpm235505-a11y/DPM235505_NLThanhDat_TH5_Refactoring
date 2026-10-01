using System;
using DPM235505_NLThanhDat_TH4_P15_IntroduceParameterObject.After;
using DPM235505_NLThanhDat_TH4_P15_IntroduceParameterObject.Real;

namespace DPM235505_NLThanhDat_TH4_P15_IntroduceParameterObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            AccountRefactored acc = new AccountRefactored();
            DateRange range = new DateRange(new DateTime(2026, 1, 1), new DateTime(2026, 12, 31));
            acc.GetFlowBetween(range);

            Console.WriteLine("\n--- REAL ---");
            ChamCongNhanVien chamCong = new ChamCongNhanVien();
            KyHanTruyVan kyHan = new KyHanTruyVan(new DateTime(2026, 10, 1), new DateTime(2026, 10, 31));
            chamCong.XuatBaoCaoChamCong("Thành Đạt", kyHan);

            Console.ReadLine();
        }
    }
}