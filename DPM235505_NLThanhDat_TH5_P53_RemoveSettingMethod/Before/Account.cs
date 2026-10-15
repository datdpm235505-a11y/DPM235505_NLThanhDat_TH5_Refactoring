namespace DPM235505_NLThanhDat_TH5_P53_RemoveSettingMethod.Before
{
    public class Account
    {
        // Có chữ set, nghĩa là ai cũng sửa được ID sau khi đã khởi tạo
        public string Id { get; set; } = "";

        public Account(string id)
        {
            Id = id;
        }
    }
}