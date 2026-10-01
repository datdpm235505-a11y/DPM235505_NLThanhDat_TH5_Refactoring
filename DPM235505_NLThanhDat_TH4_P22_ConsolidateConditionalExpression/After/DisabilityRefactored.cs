namespace DPM235505_NLThanhDat_TH4_P22_ConsolidateConditionalExpression.After
{
    public class DisabilityRefactored
    {
        private int _seniority = 1;
        private int _monthsDisabled = 15;
        private bool _isPartTime = true;

        public double DisabilityAmount()
        {
            // Gộp lại và đưa vào 1 hàm truy vấn duy nhất
            if (IsNotEligibleForDisability()) return 0;

            return 5000;
        }

        private bool IsNotEligibleForDisability()
        {
            return _seniority < 2 || _monthsDisabled > 12 || _isPartTime;
        }
    }
}