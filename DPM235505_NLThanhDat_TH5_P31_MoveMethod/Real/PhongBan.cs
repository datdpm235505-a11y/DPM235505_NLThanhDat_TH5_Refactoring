namespace DPM235505_NLThanhDat_TH5_P31_MoveMethod.Real
{
    public class PhongBan
    {
        public string TenPhong { get; set; } = "";
        public double HeSoPhuCap { get; set; } = 1.2;

        public double TinhPhuCap(double luongCoBan)
        {
            return luongCoBan * (HeSoPhuCap - 1.0);
        }
    }
}