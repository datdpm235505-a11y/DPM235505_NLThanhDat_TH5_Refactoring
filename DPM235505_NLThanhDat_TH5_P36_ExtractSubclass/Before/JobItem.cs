namespace DPM235505_NLThanhDat_TH5_P36_ExtractSubclass.Before
{
    public class JobItem
    {
        public int TotalPrice { get; set; }
        public int UnitPrice { get; set; }
        // Thuộc tính Employee này chỉ dùng cho loại công việc "nhân công", còn vật tư thì không cần
        public string Employee { get; set; } = "";
        public bool IsLabor { get; set; }
    }
}