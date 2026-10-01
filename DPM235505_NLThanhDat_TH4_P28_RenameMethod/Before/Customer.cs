namespace DPM235505_NLThanhDat_TH4_P28_RenameMethod.Before
{
    public class Customer
    {
        public string Nm { get; set; } = "";

        // Tên hàm viết tắt tối nghĩa (Bad smell)
        public string GetNm()
        {
            return Nm;
        }
    }
}