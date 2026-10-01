namespace DPM235505_NLThanhDat_TH4_P22_ConsolidateConditionalExpression.Before
{
    public class Disability
    {
        private int _seniority = 1;
        private int _monthsDisabled = 15;
        private bool _isPartTime = true;

        public double DisabilityAmount()
        {
            // Nhiều lệnh if trả về cùng kết quả 0 (Bad smell)
            if (_seniority < 2) return 0;
            if (_monthsDisabled > 12) return 0;
            if (_isPartTime) return 0;

            return 5000; // Đủ điều kiện nhận trợ cấp
        }
    }
}