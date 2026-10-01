using System;

namespace DPM235505_NLThanhDat_TH4_P14_IntroduceForeignMethod.After
{
    public class ReportRefactored
    {
        public void Process()
        {
            DateTime previousEnd = DateTime.Now;
            DateTime nextWeek = NextWeek(previousEnd); // Gọi hàm ngoại lai
            Console.WriteLine("Ngày hết hạn báo cáo: " + nextWeek.ToString("dd/MM/yyyy"));
        }

        // Tách hẳn logic thao tác với thư viện DateTime thành hàm riêng
        private static DateTime NextWeek(DateTime arg)
        {
            return new DateTime(arg.Year, arg.Month, arg.Day).AddDays(7);
        }
    }
}