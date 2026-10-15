namespace DPM235505_NLThanhDat_TH5_P58_IntroduceLocalExtension.Real
{
    // Mở rộng thêm chức năng in tiền chuẩn Việt Nam cho kiểu Double
    public static class DoubleExtensions
    {
        public static string ToVND(this double amount)
        {
            return $"{amount:N0} VNĐ";
        }
    }
}