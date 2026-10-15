namespace DPM235505_NLThanhDat_TH5_P36_ExtractSubclass.After
{
    // Class con tách ra để chứa thông tin dành riêng cho loại công việc nhân công
    public class LaborItem : JobItemRefactored
    {
        public string Employee { get; set; } = "";
    }
}