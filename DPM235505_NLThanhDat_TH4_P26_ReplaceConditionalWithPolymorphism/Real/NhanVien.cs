using System;

namespace DPM235505_NLThanhDat_TH4_P26_ReplaceConditionalWithPolymorphism.Real
{
    // Áp dụng tính Đa hình (Polymorphism) để tính lương cho từng loại nhân viên
    public abstract class NhanVien
    {
        public string Ten { get; set; } = "";
        public abstract double TinhLuong();
    }

    public class NhanVienThoiVu : NhanVien
    {
        public override double TinhLuong() => 3000000; // 3 triệu
    }

    public class NhanVienChinhThuc : NhanVien
    {
        public override double TinhLuong() => 15000000; // 15 triệu
    }
}