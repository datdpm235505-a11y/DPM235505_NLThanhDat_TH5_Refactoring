using System;
using DPM235505_NLThanhDat_TH5_P56_ChangeValueToReference.After;
using DPM235505_NLThanhDat_TH5_P56_ChangeValueToReference.Real;

namespace DPM235505_NLThanhDat_TH5_P56_ChangeValueToReference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            OrderRefactored o1 = new OrderRefactored("Alice");
            OrderRefactored o2 = new OrderRefactored("Alice");

            // o1 và o2 nay đã trỏ chung vào cùng 1 object "Alice"
            Console.WriteLine("Hai order có cùng 1 object Customer? " + (o1.Customer == o2.Customer));

            Console.WriteLine("\n--- REAL ---");
            HoaDonBanHang hd1 = new HoaDonBanHang("0909123456", "Thành Đạt"); // Tạo mới
            HoaDonBanHang hd2 = new HoaDonBanHang("0909123456", "Thành Đạt"); // Tái sử dụng tham chiếu cũ

            Console.ReadLine();
        }
    }
}