namespace DPM235505_NLThanhDat_TH5_P42_ReplaceTypeCodeWithStateStrategy.Real
{
    public abstract class HinhThucVanChuyen
    {
        public abstract double TinhPhi(double trongLuong);
    }

    public class GiaoHangThuong : HinhThucVanChuyen
    {
        public override double TinhPhi(double trongLuong) => trongLuong * 15000;
    }

    public class GiaoHangHoaToc : HinhThucVanChuyen
    {
        public override double TinhPhi(double trongLuong) => trongLuong * 30000 + 20000;
    }
}