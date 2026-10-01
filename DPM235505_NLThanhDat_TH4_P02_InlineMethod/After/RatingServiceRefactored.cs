namespace DPM235505_NLThanhDat_TH4_P02_InlineMethod.After
{
    public class RatingServiceRefactored
    {
        private int _numberOfLateDeliveries;

        public RatingServiceRefactored(int lateDeliveries)
        {
            _numberOfLateDeliveries = lateDeliveries;
        }

        public int GetRating()
        {
            // Đã gộp (inline) biểu thức so sánh trực tiếp vào đây
            return (_numberOfLateDeliveries > 5) ? 2 : 1;
        }
    }
}