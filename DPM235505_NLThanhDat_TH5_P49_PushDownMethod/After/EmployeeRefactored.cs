namespace DPM235505_NLThanhDat_TH5_P49_PushDownMethod.After
{
    public class EmployeeRefactored { }

    public class Salesman : EmployeeRefactored
    {
        // Đẩy hàm GetQuota xuống đúng nơi thuộc về nó
        public double GetQuota() => 50000;
    }

    public class Engineer : EmployeeRefactored { }
}