using System;

namespace DPM235505_NLThanhDat_TH4_P27_IntroduceNullObject.Real
{
    public interface IMaGiamGia
    {
        double TinhTienGiam(double tongTien);
    }

    public class MaGiamGiaVip : IMaGiamGia
    {
        public double TinhTienGiam(double tongTien) => tongTien * 0.2; // Giảm 20%
    }

    // Null Object: Dành cho những ai không nhập mã giảm giá
    public class KhongCoMaGiamGia : IMaGiamGia
    {
        public double TinhTienGiam(double tongTien) => 0; // Giảm 0đ
    }
}