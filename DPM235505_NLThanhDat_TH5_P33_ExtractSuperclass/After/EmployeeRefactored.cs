namespace DPM235505_NLThanhDat_TH5_P33_ExtractSuperclass.After
{
    public class EmployeeRefactored : Party
    {
        public string Id { get; set; } = "";
        public double MonthlySalary { get; set; }

        public override double GetAnnualCost() => MonthlySalary * 12;
    }
}