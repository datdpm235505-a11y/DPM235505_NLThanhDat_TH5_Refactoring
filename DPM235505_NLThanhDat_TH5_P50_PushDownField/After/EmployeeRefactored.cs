namespace DPM235505_NLThanhDat_TH5_P50_PushDownField.After
{
    public class EmployeeRefactored { }

    public class Salesman : EmployeeRefactored
    {
        // Đẩy thuộc tính xuống Lớp con Salesman
        public double Quota { get; set; }
    }

    public class Engineer : EmployeeRefactored { }
}