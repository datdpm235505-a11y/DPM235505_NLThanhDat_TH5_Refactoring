namespace DPM235505_NLThanhDat_TH5_P31_MoveMethod.Before
{
    public class Account
    {
        public AccountType Type { get; set; } = new AccountType();
        public int DaysOverdrawn { get; set; }

        public double OverdraftCharge()
        {
            if (Type.IsPremium)
            {
                double result = 10;
                if (DaysOverdrawn > 7) result += (DaysOverdrawn - 7) * 0.85;
                return result;
            }
            else
            {
                return DaysOverdrawn * 1.75;
            }
        }
    }
}