using System;

namespace DPM235505_NLThanhDat_TH5_P35_CollapseHierarchy.Real
{
    public class NhanVien
    {
        public string TenNV { get; set; } = "";
        public string PhongBan { get; set; } = "";

        // Thay vì tạo class NhanVienVanPhong trống rỗng, ta gộp vào NhanVien
        public void InThongTin()
        {
            Console.WriteLine($"Nhân viên: {TenNV} | Phòng: {PhongBan}");
        }
    }
}