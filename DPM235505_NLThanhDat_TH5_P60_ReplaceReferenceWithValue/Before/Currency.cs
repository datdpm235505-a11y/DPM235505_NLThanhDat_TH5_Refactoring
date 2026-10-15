namespace DPM235505_NLThanhDat_TH5_P60_ReplaceReferenceWithValue.Before
{
    public class Currency
    {
        // Thuộc tính có setter, có thể bị sửa đổi bất ngờ gây side-effect
        public string Code { get; set; } = "";

        public Currency(string code)
        {
            Code = code;
        }
    }
}