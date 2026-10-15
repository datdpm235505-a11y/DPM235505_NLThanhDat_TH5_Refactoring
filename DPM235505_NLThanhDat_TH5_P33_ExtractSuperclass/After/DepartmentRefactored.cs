namespace DPM235505_NLThanhDat_TH5_P33_ExtractSuperclass.After
{
    public class DepartmentRefactored : Party
    {
        public double TotalStaffCost { get; set; }

        public override double GetAnnualCost() => TotalStaffCost;
    }
}