namespace DPM235505_NLThanhDat_TH5_P34_ExtractInterface.Before
{
    public class Employee
    {
        public double Rate { get; set; } = 50;
        public bool HasSpecialSkill { get; set; } = true;

        public double GetChargeRate()
        {
            return HasSpecialSkill ? Rate * 1.5 : Rate;
        }
    }
}