namespace DPM235505_NLThanhDat_TH4_P25_ReplaceNestedConditional.Before
{
    public class Payout
    {
        private bool _isDead = false;
        private bool _isSeparated = false;
        private bool _isRetired = false;

        public double GetPayAmount()
        {
            double result;
            // Lồng nhau chằng chịt
            if (_isDead) result = DeadAmount();
            else
            {
                if (_isSeparated) result = SeparatedAmount();
                else
                {
                    if (_isRetired) result = RetiredAmount();
                    else result = NormalPayAmount();
                }
            }
            return result;
        }

        private double DeadAmount() => 0;
        private double SeparatedAmount() => 50;
        private double RetiredAmount() => 100;
        private double NormalPayAmount() => 1000;
    }
}