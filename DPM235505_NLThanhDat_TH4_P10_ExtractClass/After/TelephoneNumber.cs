namespace DPM235505_NLThanhDat_TH4_P10_ExtractClass.After
{
    public class TelephoneNumber
    {
        public string AreaCode { get; set; } = "";
        public string Number { get; set; } = "";

        public string GetTelephoneNumber() => $"({AreaCode}) {Number}";
    }
}