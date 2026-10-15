using System;

namespace DPM235505_NLThanhDat_TH5_P52_ReplaceConstructorWithFactory.Real
{
    public class TaiKhoanNganHang
    {
        public string LoaiTaiKhoan { get; private set; } = "";
        public double HanMuc { get; private set; }

        private TaiKhoanNganHang(string loai, double hanMuc)
        {
            LoaiTaiKhoan = loai;
            HanMuc = hanMuc;
        }

        // Factory Methods tạo sẵn các gói tài khoản chuẩn
        public static TaiKhoanNganHang MoTaiKhoanSinhVien() => new TaiKhoanNganHang("Sinh Viên", 5000000);
        public static TaiKhoanNganHang MoTaiKhoanVIP() => new TaiKhoanNganHang("Khách Hàng VIP", 500000000);

        public void InThongTin()
        {
            Console.WriteLine($"Tài khoản: {LoaiTaiKhoan} | Hạn mức: {HanMuc:N0} VNĐ");
        }
    }
}