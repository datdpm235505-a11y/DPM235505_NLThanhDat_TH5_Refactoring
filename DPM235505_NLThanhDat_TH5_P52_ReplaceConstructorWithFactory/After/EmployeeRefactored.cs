namespace DPM235505_NLThanhDat_TH5_P52_ReplaceConstructorWithFactory.After
{
    public class EmployeeRefactored
    {
        public int Type { get; private set; }

        // Chuyển Constructor thành private
        private EmployeeRefactored(int type)
        {
            Type = type;
        }

        // Factory Methods: Tên hàm nói lên tất cả
        public static EmployeeRefactored CreateEngineer() => new EmployeeRefactored(0);
        public static EmployeeRefactored CreateSalesman() => new EmployeeRefactored(1);
    }
}