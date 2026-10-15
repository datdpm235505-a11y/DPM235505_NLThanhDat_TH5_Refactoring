namespace DPM235505_NLThanhDat_TH5_P33_ExtractSuperclass.Real
{
    public abstract class DoiTuongNhanSu
    {
        public string MaSo { get; set; } = "";
        public string HoTen { get; set; } = "";
        public string Email { get; set; } = "";

        public abstract void InRole();
    }
}