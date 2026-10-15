namespace DPM235505_NLThanhDat_TH5_P42_ReplaceTypeCodeWithStateStrategy.After
{
    // Strategy Pattern (State)
    public abstract class EmployeeType
    {
        public abstract int PayAmount(EmployeeRefactored emp);
    }

    public class Engineer : EmployeeType
    {
        public override int PayAmount(EmployeeRefactored emp) => emp.MonthlySalary;
    }

    public class Salesman : EmployeeType
    {
        public override int PayAmount(EmployeeRefactored emp) => emp.MonthlySalary + emp.Commission;
    }
}