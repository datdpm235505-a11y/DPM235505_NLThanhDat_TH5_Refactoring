namespace DPM235505_NLThanhDat_TH5_P45_ReplaceParameterWithExplicitMethods.After
{
    public class ShapeRefactored
    {
        public int Height { get; set; }
        public int Width { get; set; }

        // Tách ra thành các hàm cụ thể, lập trình viên gọi hàm nào là biết chức năng hàm đó
        public void SetHeight(int value) => Height = value;

        public void SetWidth(int value) => Width = value;
    }
}