namespace DPM235505_NLThanhDat_TH5_P44_ParameterizeMethod.After
{
    public class EmployeeRefactored
    {
        public double Salary { get; set; } = 1000;

        // Gộp lại thành 1 hàm duy nhất nhận tham số
        public void RaiseSalary(double percentage)
        {
            Salary *= (1 + percentage / 100);
        }
    }
}