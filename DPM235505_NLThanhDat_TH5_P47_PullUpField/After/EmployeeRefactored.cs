namespace DPM235505_NLThanhDat_TH5_P47_PullUpField.After
{
    public class EmployeeRefactored
    {
        // Kéo Name lên Lớp cha
        public string Name { get; set; } = "";
    }

    public class Salesman : EmployeeRefactored { }

    public class Engineer : EmployeeRefactored { }
}