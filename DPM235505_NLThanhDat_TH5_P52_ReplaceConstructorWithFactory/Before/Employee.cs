namespace DPM235505_NLThanhDat_TH5_P52_ReplaceConstructorWithFactory.Before
{
    public class Employee
    {
        public int Type { get; set; }

        public Employee(int type)
        {
            Type = type; // Nhìn vào không biết type 1 là gì, type 2 là gì
        }
    }
}