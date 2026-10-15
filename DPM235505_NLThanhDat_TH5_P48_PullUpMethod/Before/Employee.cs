namespace DPM235505_NLThanhDat_TH5_P48_PullUpMethod.Before
{
    public class Employee { }

    public class RegularEmployee : Employee
    {
        public double CalculateBonus(double baseSalary) => baseSalary * 0.1; // Code trùng lặp
    }

    public class Manager : Employee
    {
        public double CalculateBonus(double baseSalary) => baseSalary * 0.1; // Code trùng lặp
    }
}