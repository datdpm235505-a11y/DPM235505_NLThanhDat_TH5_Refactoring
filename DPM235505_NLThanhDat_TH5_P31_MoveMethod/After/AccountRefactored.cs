namespace DPM235505_NLThanhDat_TH5_P31_MoveMethod.After
{
    public class AccountRefactored
    {
        public AccountTypeRefactored Type { get; set; } = new AccountTypeRefactored();
        public int DaysOverdrawn { get; set; }

        public double OverdraftCharge()
        {
            return Type.OverdraftCharge(DaysOverdrawn);
        }
    }
}