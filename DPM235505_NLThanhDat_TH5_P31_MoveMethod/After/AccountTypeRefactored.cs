namespace DPM235505_NLThanhDat_TH5_P31_MoveMethod.After
{
    public class AccountTypeRefactored
    {
        public bool IsPremium { get; set; }

        // Đã chuyển hàm về đúng Class quản lý loại tài khoản
        public double OverdraftCharge(int daysOverdrawn)
        {
            if (IsPremium)
            {
                double result = 10;
                if (daysOverdrawn > 7) result += (daysOverdrawn - 7) * 0.85;
                return result;
            }
            else
            {
                return daysOverdrawn * 1.75;
            }
        }
    }
}