namespace DPM235505_NLThanhDat_TH5_P34_ExtractInterface.Real
{
    public class NhanVienThoiVu : ITinhLuong
    {
        public int SoGioLam { get; set; } = 80;
        public double LuongTheoGio { get; set; } = 50000;

        public double TinhLuongThucLanh() => SoGioLam * LuongTheoGio;
    }
}