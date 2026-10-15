namespace DPM235505_NLThanhDat_TH5_P41_ReplaceTypeCodeWithClass.After
{
    public class PersonRefactored
    {
        // Bắt buộc phải truyền đối tượng BloodGroup, không sợ truyền bậy
        public BloodGroup BloodGroup { get; set; } = BloodGroup.O;
        public string Name { get; set; } = "";
    }
}