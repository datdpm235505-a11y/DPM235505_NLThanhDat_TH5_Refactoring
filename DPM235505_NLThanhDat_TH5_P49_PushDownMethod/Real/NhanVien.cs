using System;

namespace DPM235505_NLThanhDat_TH5_P49_PushDownMethod.Real
{
    public class NhanVien
    {
        public string TenNV { get; set; } = "";
    }

    public class NhanVienSale : NhanVien
    {
        // Hàm tính hoa hồng chỉ áp dụng cho Sale, đẩy xuống class NhanVienSale
        public void TinhHoaHong(double doanhThu)
        {
            Console.WriteLine($"Nhân viên Sale {TenNV} nhận hoa hồng: {doanhThu * 0.05:N0} VNĐ");
        }
    }

    public class NhanVienIT : NhanVien
    {
        public void FixBug()
        {
            Console.WriteLine($"IT {TenNV} đang fix bug...");
        }
    }
}