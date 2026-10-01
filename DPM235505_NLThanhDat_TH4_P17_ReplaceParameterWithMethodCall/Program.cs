using System;
using DPM235505_NLThanhDat_TH4_P17_ReplaceParameterWithMethodCall.After;
using DPM235505_NLThanhDat_TH4_P17_ReplaceParameterWithMethodCall.Real;

namespace DPM235505_NLThanhDat_TH4_P17_ReplaceParameterWithMethodCall
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            OrderRefactored order = new OrderRefactored();
            Console.WriteLine($"Giá sau chiết khấu: {order.CalculatePrice()}");

            Console.WriteLine("\n--- REAL ---");
            TinhTienBaoHiem bh = new TinhTienBaoHiem();
            bh.InThongTinBaoHiem("Thành Đạt");

            Console.ReadLine();
        }
    }
}