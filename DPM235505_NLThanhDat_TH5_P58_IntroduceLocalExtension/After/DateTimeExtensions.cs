using System;

namespace DPM235505_NLThanhDat_TH5_P58_IntroduceLocalExtension.After
{
    // Tạo lớp tĩnh (static class) và hàm tĩnh chứa từ khóa 'this' để mở rộng
    public static class DateTimeExtensions
    {
        public static DateTime NextWeek(this DateTime date)
        {
            return date.AddDays(7);
        }
    }
}