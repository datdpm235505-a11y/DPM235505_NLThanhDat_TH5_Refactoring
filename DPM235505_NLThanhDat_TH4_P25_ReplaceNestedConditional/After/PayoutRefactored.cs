namespace DPM235505_NLThanhDat_TH4_P25_ReplaceNestedConditional.After
{
    public class PayoutRefactored
    {
        private bool _isDead = false;
        private bool _isSeparated = false;
        private bool _isRetired = false;

        public double GetPayAmount()
        {
            // Các Mệnh đề bảo vệ (Guard Clauses) - Trả về sớm
            if (_isDead) return DeadAmount();
            if (_isSeparated) return SeparatedAmount();
            if (_isRetired) return RetiredAmount();

            // Luồng xử lý chính nằm ở cuối, không bị lồng vào trong các khối else
            return NormalPayAmount();
        }

        private double DeadAmount() => 0;
        private double SeparatedAmount() => 50;
        private double RetiredAmount() => 100;
        private double NormalPayAmount() => 1000;
    }
}