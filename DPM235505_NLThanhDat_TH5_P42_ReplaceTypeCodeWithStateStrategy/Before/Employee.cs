namespace DPM235505_NLThanhDat_TH5_P42_ReplaceTypeCodeWithStateStrategy.Before
{
    public class Employee
    {
        public const int ENGINEER = 0;
        public const int SALESMAN = 1;

        public int Type { get; set; }
        public int MonthlySalary { get; set; } = 1000;
        public int Commission { get; set; } = 500;

        public int PayAmount()
        {
            switch (Type)
            {
                case ENGINEER:
                    return MonthlySalary;
                case SALESMAN:
                    return MonthlySalary + Commission;
                default:
                    return 0;
            }
        }
    }
}