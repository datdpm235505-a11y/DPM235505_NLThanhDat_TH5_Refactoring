using System;
using DPM235505_NLThanhDat_TH4_P25_ReplaceNestedConditional.After;
using DPM235505_NLThanhDat_TH4_P25_ReplaceNestedConditional.Real;

namespace DPM235505_NLThanhDat_TH4_P25_ReplaceNestedConditional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            PayoutRefactored pay = new PayoutRefactored();
            Console.WriteLine("Tiền thanh toán: " + pay.GetPayAmount());

            Console.WriteLine("\n--- REAL ---");
            TinhTienThuong thuong = new TinhTienThuong();
            thuong.ThuongNhanVien("Thành Đạt", false, false, 24); // Đi làm bình thường
            thuong.ThuongNhanVien("Nguyễn B", true, false, 0); // Đã nghỉ việc

            Console.ReadLine();
        }
    }
}