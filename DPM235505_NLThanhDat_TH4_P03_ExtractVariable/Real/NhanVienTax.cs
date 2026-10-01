using System;

namespace DPM235505_NLThanhDat_TH4_P03_ExtractVariable.Real
{
    public class NhanVienTax
    {
        public void TinhThueThuNhap(string tenNV, double luongCoBan, double thuong)
        {
            // Tách các biến trung gian để rõ ràng logic nghiệp vụ
            double tongThuNhap = luongCoBan + thuong;
            double giamTruGiaCanh = 11000000; // Mức giảm trừ tiêu chuẩn 11 triệu
            double thuNhapChiuThue = Math.Max(0, tongThuNhap - giamTruGiaCanh);
            double tienThue = thuNhapChiuThue * 0.1; // Thuế 10% cho phần dư

            Console.WriteLine($"Nhân viên: {tenNV}");
            Console.WriteLine($"- Tổng thu nhập: {tongThuNhap:N0} VNĐ");
            Console.WriteLine($"- Thu nhập chịu thuế: {thuNhapChiuThue:N0} VNĐ");
            Console.WriteLine($"=> Thuế phải nộp: {tienThue:N0} VNĐ\n");
        }
    }
}