namespace DPM235505_NLThanhDat_TH4_P11_InlineClass.After
{
    public class PersonRefactored
    {
        public string Name { get; set; } = "";
        // Đã gộp thuộc tính Number thẳng vào đây, không cần class TelephoneNumber nữa
        public string PhoneNumber { get; set; } = "";
    }
}