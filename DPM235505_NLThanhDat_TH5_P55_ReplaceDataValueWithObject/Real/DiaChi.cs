namespace DPM235505_NLThanhDat_TH5_P55_ReplaceDataValueWithObject.Real
{
    public class DiaChi
    {
        public string Duong { get; set; } = "";
        public string ThanhPho { get; set; } = "";

        public string LayDiaChiDayDu() => $"{Duong}, {ThanhPho}";
    }
}