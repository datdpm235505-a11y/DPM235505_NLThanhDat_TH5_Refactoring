namespace DPM235505_NLThanhDat_TH4_P10_ExtractClass.Real
{
    public class DiaChi
    {
        // Gán giá trị mặc định là chuỗi rỗng để triệt tiêu cảnh báo CS8618
        public string SoNha { get; set; } = "";
        public string Duong { get; set; } = "";
        public string ThanhPho { get; set; } = "";

        public string LayDiaChiDayDu() => $"{SoNha} {Duong}, {ThanhPho}";
    }
}