using System;
using DPM235505_NLThanhDat_TH4_P30_ReplaceTypeCodeWithSubclasses.After;
using DPM235505_NLThanhDat_TH4_P30_ReplaceTypeCodeWithSubclasses.Real;

namespace DPM235505_NLThanhDat_TH4_P30_ReplaceTypeCodeWithSubclasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            ProductRefactored p1 = new ElectronicsProduct();
            ProductRefactored p2 = new FoodProduct();
            p1.PrintCategory();
            p2.PrintCategory();

            Console.WriteLine("\n--- REAL ---");
            double tongBill = 1250000;

            // Khách chọn trả tiền mặt
            HinhThucThanhToan tt1 = new ThanhToanTienMat();
            tt1.TienHanhThanhToan(tongBill);

            // Khách chọn quét mã
            HinhThucThanhToan tt2 = new ThanhToanChuyenKhoan();
            tt2.TienHanhThanhToan(tongBill);

            Console.ReadLine();
        }
    }
}