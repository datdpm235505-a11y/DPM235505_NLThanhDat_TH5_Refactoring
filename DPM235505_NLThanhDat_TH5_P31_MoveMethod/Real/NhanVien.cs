using System;

namespace DPM235505_NLThanhDat_TH5_P31_MoveMethod.Real
{
    public class NhanVien
    {
        public string TenNV { get; set; } = "";
        public double LuongCoBan { get; set; }
        public PhongBan Phong { get; set; } = new PhongBan();

        public void InLuong()
        {
            double phuCap = Phong.TinhPhuCap(LuongCoBan);
            double tongLuong = LuongCoBan + phuCap;
            Console.WriteLine($"Nhân viên: {TenNV} ({Phong.TenPhong})");
            Console.WriteLine($"+ Lương CB: {LuongCoBan:N0} VNĐ | Phụ cấp: {phuCap:N0} VNĐ");
            Console.WriteLine($"=> Tổng thực nhận: {tongLuong:N0} VNĐ\n");
        }
    }
}