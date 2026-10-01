namespace DPM235505_NLThanhDat_TH4_P10_ExtractClass.Before
{
    public class Person
    {
        public string Name { get; set; } = "";
        public string OfficeAreaCode { get; set; } = "";
        public string OfficeNumber { get; set; } = "";

        public string GetTelephoneNumber() => $"({OfficeAreaCode}) {OfficeNumber}";
    }
}