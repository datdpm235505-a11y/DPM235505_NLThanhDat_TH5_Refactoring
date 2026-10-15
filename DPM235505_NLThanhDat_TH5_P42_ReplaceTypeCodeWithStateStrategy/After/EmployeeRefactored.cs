namespace DPM235505_NLThanhDat_TH5_P42_ReplaceTypeCodeWithStateStrategy.After
{
    public class EmployeeRefactored
    {
        // Loại nhân viên được tách riêng thành Strategy, dễ dàng thay đổi khi đang chạy
        public EmployeeType Type { get; set; } = new Engineer();

        public int MonthlySalary { get; set; } = 1000;
        public int Commission { get; set; } = 500;

        public int PayAmount()
        {
            return Type.PayAmount(this); // Ủy quyền tính toán cho Strategy
        }
    }
}