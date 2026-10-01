namespace DPM235505_NLThanhDat_TH4_P02_InlineMethod.Before
{
    public class RatingService
    {
        private int _numberOfLateDeliveries;

        public RatingService(int lateDeliveries)
        {
            _numberOfLateDeliveries = lateDeliveries;
        }

        public int GetRating()
        {
            return MoreThanFiveLateDeliveries() ? 2 : 1;
        }

        // Hàm này quá đơn giản, không đáng để tách riêng
        private bool MoreThanFiveLateDeliveries()
        {
            return _numberOfLateDeliveries > 5;
        }
    }
}