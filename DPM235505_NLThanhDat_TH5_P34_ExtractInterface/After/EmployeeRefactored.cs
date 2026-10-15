namespace DPM235505_NLThanhDat_TH5_P34_ExtractInterface.After
{
    public class EmployeeRefactored : IBillable
    {
        public double Rate { get; set; } = 50;
        public bool HasSpecialSkill { get; set; } = true;

        public double GetChargeRate()
        {
            return HasSpecialSkill ? Rate * 1.5 : Rate;
        }
    }
}