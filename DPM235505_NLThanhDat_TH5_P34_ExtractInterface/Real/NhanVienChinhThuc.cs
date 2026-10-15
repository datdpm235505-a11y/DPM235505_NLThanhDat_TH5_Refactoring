namespace DPM235505_NLThanhDat_TH5_P34_ExtractInterface.Real
{
    public class NhanVienChinhThuc : ITinhLuong
    {
        public double LuongCoBan { get; set; } = 15000000;
        public double ThuongKPI { get; set; } = 3000000;

        public double TinhLuongThucLanh() => LuongCoBan + ThuongKPI;
    }
}