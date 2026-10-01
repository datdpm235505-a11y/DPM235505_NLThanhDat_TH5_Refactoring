using System;
using DPM235505_NLThanhDat_TH4_P27_IntroduceNullObject.After;
using DPM235505_NLThanhDat_TH4_P27_IntroduceNullObject.Real;

namespace DPM235505_NLThanhDat_TH4_P27_IntroduceNullObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            BillingRefactored billing = new BillingRefactored();
            ICustomer unknown = new NullCustomer(); // Khởi tạo Null Object
            billing.Process(unknown); // Gọi thoải mái không sợ lỗi Null

            Console.WriteLine("\n--- REAL ---");
            double donHang = 1000000;
            // Thay vì truyền null, ta truyền đối tượng KhongCoMaGiamGia
            IMaGiamGia maCuaThanhDat = new KhongCoMaGiamGia();

            double tienGiam = maCuaThanhDat.TinhTienGiam(donHang);
            Console.WriteLine($"Tiền giảm giá: {tienGiam} VNĐ. Phải thanh toán: {donHang - tienGiam:N0} VNĐ");

            Console.ReadLine();
        }
    }
}