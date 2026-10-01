namespace DPM235505_NLThanhDat_TH4_P13_RemoveMiddleMan.After
{
    public class PersonRefactored
    {
        // Mở hẳn thuộc tính ra cho Client tự gọi, bỏ các hàm trung gian
        public Department Department { get; set; } = new Department();
    }
}