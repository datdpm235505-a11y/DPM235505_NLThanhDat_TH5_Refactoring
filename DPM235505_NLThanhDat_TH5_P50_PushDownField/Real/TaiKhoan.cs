using System;

namespace DPM235505_NLThanhDat_TH5_P50_PushDownField.Real
{
    public class TaiKhoan
    {
        public string ChuTaiKhoan { get; set; } = "";
        public double SoDu { get; set; }
    }

    public class TaiKhoanTietKiem : TaiKhoan
    {
        // Thuộc tính LaiSuat chỉ có ở TK Tiết kiệm, đẩy xuống đây
        public double LaiSuat { get; set; }

        public void InThongTin()
        {
            Console.WriteLine($"TK Tiết kiệm của {ChuTaiKhoan} | Lãi suất: {LaiSuat}%");
        }
    }

    public class TaiKhoanThanhToan : TaiKhoan
    {
        public void InThongTin()
        {
            Console.WriteLine($"TK Thanh toán của {ChuTaiKhoan} | Số dư: {SoDu:N0} VNĐ");
        }
    }
}