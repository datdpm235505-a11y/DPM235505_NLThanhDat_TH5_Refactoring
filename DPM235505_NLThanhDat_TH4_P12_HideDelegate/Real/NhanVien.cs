using System;

namespace DPM235505_NLThanhDat_TH4_P12_HideDelegate.Real
{
    public class NhanVien
    {
        public string TenNV { get; set; } = "";
        private PhongBan _phongBan = new PhongBan();

        public void CapNhatPhongBan(PhongBan pb) => _phongBan = pb;

        // Ẩn chi tiết Phòng Ban, lấy thẳng tên Sếp
        public void InThongTinSep()
        {
            Console.WriteLine($"Sếp của {TenNV} là: {_phongBan.TruongPhong}");
        }
    }
}