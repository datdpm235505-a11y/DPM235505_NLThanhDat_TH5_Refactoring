namespace DPM235505_NLThanhDat_TH5_P32_MoveField.After
{
    public class AccountRefactored
    {
        public AccountTypeRefactored Type { get; set; } = new AccountTypeRefactored();

        public double InterestForAmount(double amount, int days)
        {
            return Type.InterestRate * amount * days / 365;
        }
    }
}