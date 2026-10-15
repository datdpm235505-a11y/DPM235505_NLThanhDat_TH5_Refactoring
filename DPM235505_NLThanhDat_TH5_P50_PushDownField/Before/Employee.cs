namespace DPM235505_NLThanhDat_TH5_P50_PushDownField.Before
{
    public class Employee
    {
        // Thuộc tính Quota (Chỉ tiêu) vô dụng với Engineer
        public double Quota { get; set; }
    }

    public class Salesman : Employee { }

    public class Engineer : Employee { }
}