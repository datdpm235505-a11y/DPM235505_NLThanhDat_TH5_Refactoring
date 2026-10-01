using System;

namespace DPM235505_NLThanhDat_TH4_P14_IntroduceForeignMethod.Before
{
    public class Report
    {
        public void Process()
        {
            DateTime previousEnd = DateTime.Now;
            // Xử lý trực tiếp loằng ngoằng
            DateTime nextWeek = new DateTime(previousEnd.Year, previousEnd.Month, previousEnd.Day).AddDays(7);
            Console.WriteLine("Ngày hết hạn báo cáo: " + nextWeek.ToString("dd/MM/yyyy"));
        }
    }
}