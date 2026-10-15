namespace DPM235505_NLThanhDat_TH5_P48_PullUpMethod.After
{
    public class EmployeeRefactored
    {
        // Kéo phương thức chung lên Lớp cha
        public double CalculateBonus(double baseSalary)
        {
            return baseSalary * 0.1;
        }
    }

    public class RegularEmployee : EmployeeRefactored { }

    public class Manager : EmployeeRefactored { }
}