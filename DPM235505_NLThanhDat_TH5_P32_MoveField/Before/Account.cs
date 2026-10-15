namespace DPM235505_NLThanhDat_TH5_P32_MoveField.Before
{
    public class Account
    {
        public AccountType Type { get; set; } = new AccountType();
        public double InterestRate { get; set; }

        public double InterestForAmount(double amount, int days)
        {
            return InterestRate * amount * days / 365;
        }
    }
}