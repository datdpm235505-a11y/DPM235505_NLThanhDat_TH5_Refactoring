namespace DPM235505_NLThanhDat_TH5_P49_PushDownMethod.Before
{
    public class Employee
    {
        // Hàm GetQuota() (lấy chỉ tiêu) chỉ dành cho Salesman, Engineer không cần hàm này
        public double GetQuota() => 50000;
    }

    public class Salesman : Employee { }

    public class Engineer : Employee { }
}