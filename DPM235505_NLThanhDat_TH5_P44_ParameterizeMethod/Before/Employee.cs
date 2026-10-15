namespace DPM235505_NLThanhDat_TH5_P44_ParameterizeMethod.Before
{
    public class Employee
    {
        public double Salary { get; set; } = 1000;

        // Quá nhiều hàm na ná nhau (Bad smell)
        public void Raise5Percent() => Salary *= 1.05;
        public void Raise10Percent() => Salary *= 1.10;
    }
}