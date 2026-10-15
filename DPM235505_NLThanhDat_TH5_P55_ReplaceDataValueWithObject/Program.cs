using System;
using DPM235505_NLThanhDat_TH5_P55_ReplaceDataValueWithObject.After;
using DPM235505_NLThanhDat_TH5_P55_ReplaceDataValueWithObject.Real;

namespace DPM235505_NLThanhDat_TH5_P55_ReplaceDataValueWithObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            OrderRefactored order = new OrderRefactored("John Doe");
            order.Customer.PhoneNumber = "0901234567";
            Console.WriteLine($"Khách: {order.Customer.Name} - SĐT: {order.Customer.PhoneNumber}");

            Console.WriteLine("\n--- REAL ---");
            NhanVienGiaoHang shipper = new NhanVienGiaoHang { TenNV = "Thành Đạt" };
            shipper.DiaChiGiao.Duong = "Ung Văn Khiêm";
            shipper.DiaChiGiao.ThanhPho = "Long Xuyên";
            shipper.InPhieuGiao();

            Console.ReadLine();
        }
    }
}