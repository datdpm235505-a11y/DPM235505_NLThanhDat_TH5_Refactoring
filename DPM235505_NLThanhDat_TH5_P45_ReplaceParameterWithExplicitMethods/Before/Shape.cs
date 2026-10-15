namespace DPM235505_NLThanhDat_TH5_P45_ReplaceParameterWithExplicitMethods.Before
{
    public class Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public void SetValue(string name, int value)
        {
            // Tham số name quyết định luồng rẽ nhánh, rất dễ truyền sai chính tả
            if (name == "height")
                Height = value;
            if (name == "width")
                Width = value;
        }
    }
}