using System;

namespace DPM235505_NLThanhDat_TH4_P19_ReplaceMagicNumber.Real
{
    public class TinhLuongLamThem
    {
        // Khai báo rõ ràng hệ số nhân dịp Lễ Tết
        private const double HE_SO_LUONG_NGAY_LE = 3.0;

        public void InLuongNgayLe(string tenNV, double luongCoBan)
        {
            double luongThucTe = luongCoBan * HE_SO_LUONG_NGAY_LE;
            Console.WriteLine($"Nhân viên {tenNV} đi làm ngày Lễ:");
            Console.WriteLine($"Nhận được lương nhân {HE_SO_LUONG_NGAY_LE} lần. Thực nhận: {luongThucTe:N0} VNĐ");
        }
    }
}