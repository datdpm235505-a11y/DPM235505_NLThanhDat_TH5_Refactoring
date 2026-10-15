namespace DPM235505_NLThanhDat_TH5_P33_ExtractSuperclass.After
{
    public abstract class Party
    {
        public string Name { get; set; } = "";
        public abstract double GetAnnualCost();
    }
}