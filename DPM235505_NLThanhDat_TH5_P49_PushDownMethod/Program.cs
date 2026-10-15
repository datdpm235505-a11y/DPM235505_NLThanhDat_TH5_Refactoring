using System;
using DPM235505_NLThanhDat_TH5_P49_PushDownMethod.After;
using DPM235505_NLThanhDat_TH5_P49_PushDownMethod.Real;

namespace DPM235505_NLThanhDat_TH5_P49_PushDownMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            Salesman sale = new Salesman();
            Console.WriteLine("Chỉ tiêu Sale: " + sale.GetQuota());

            Console.WriteLine("\n--- REAL ---");
            NhanVienSale nvSale = new NhanVienSale { TenNV = "Thành Đạt" };
            NhanVienIT nvIT = new NhanVienIT { TenNV = "Nguyễn A" };

            nvSale.TinhHoaHong(20000000);
            nvIT.FixBug();

            Console.ReadLine();
        }
    }
}