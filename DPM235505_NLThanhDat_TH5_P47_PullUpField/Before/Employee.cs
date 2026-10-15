namespace DPM235505_NLThanhDat_TH5_P47_PullUpField.Before
{
    public class Employee { }

    public class Salesman : Employee
    {
        public string Name { get; set; } = ""; // Bị trùng lặp
    }

    public class Engineer : Employee
    {
        public string Name { get; set; } = ""; // Bị trùng lặp
    }
}