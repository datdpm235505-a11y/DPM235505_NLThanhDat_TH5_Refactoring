namespace DPM235505_NLThanhDat_TH5_P53_RemoveSettingMethod.After
{
    public class AccountRefactored
    {
        // Bỏ set, thuộc tính này thành Read-only, chỉ được gán trong Constructor
        public string Id { get; }

        public AccountRefactored(string id)
        {
            Id = id;
        }
    }
}