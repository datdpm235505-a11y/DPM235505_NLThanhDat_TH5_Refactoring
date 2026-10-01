using System;

namespace DPM235505_NLThanhDat_TH4_P06_SplitTemporaryVariable.Real
{
    public class NhanVienThuNhap
    {
        public void InThuNhap(string tenNV, double luongNgay, int soNgayCong, double thuong)
        {
            Console.WriteLine($"--- Thông tin thu nhập: {tenNV} ---");

            // Biến 1: Chỉ chịu trách nhiệm lưu Lương cơ bản
            double luongCoBan = luongNgay * soNgayCong;
            Console.WriteLine($"+ Lương cơ bản: {luongCoBan:N0} VNĐ");

            // Biến 2: Chịu trách nhiệm lưu Tổng thu nhập
            // (Không tái sử dụng lại biến luongCoBan để cộng dồn)
            double tongThuNhap = luongCoBan + thuong;
            Console.WriteLine($"+ Tổng thu nhập (gồm thưởng): {tongThuNhap:N0} VNĐ\n");
        }
    }
}