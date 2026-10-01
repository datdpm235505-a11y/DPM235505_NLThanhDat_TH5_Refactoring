namespace DPM235505_NLThanhDat_TH4_P28_RenameMethod.After
{
    public class CustomerRefactored
    {
        public string Name { get; set; } = "";

        // Đổi tên cho rõ ràng, đúng chuẩn tiếng Anh
        public string GetName()
        {
            return Name;
        }
    }
}