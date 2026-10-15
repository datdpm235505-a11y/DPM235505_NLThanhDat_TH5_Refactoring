using System;

namespace DPM235505_NLThanhDat_TH5_P43_ReplaceSubclassWithFields.Real
{
    public class GoiCuoc
    {
        public string TenGoi { get; set; } = "";
        public double GiaTien { get; set; }

        public GoiCuoc(string tenGoi, double giaTien)
        {
            TenGoi = tenGoi;
            GiaTien = giaTien;
        }

        public void InThongTin()
        {
            Console.WriteLine($"Đăng ký gói: {TenGoi} - Phí: {GiaTien:N0} VNĐ/tháng");
        }

        // Thay vì tạo class GoiVip, GoiThuong. Ta tạo Factory method
        public static GoiCuoc TaoGoiVip() => new GoiCuoc("VIP", 500000);
        public static GoiCuoc TaoGoiThuong() => new GoiCuoc("Cơ Bản", 100000);
    }
}