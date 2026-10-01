namespace DPM235505_NLThanhDat_TH4_P26_ReplaceConditionalWithPolymorphism.Before
{
    public class Bird
    {
        public string Type { get; set; } = "";

        public double GetSpeed()
        {
            // Dùng switch case dựa vào Type (Bad smell khi có quá nhiều loại)
            switch (Type)
            {
                case "European": return 10;
                case "African": return 15;
                case "Norwegian": return 20;
                default: return 0;
            }
        }
    }
}