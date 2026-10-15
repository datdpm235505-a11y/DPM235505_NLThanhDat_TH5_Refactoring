using System;

namespace DPM235505_NLThanhDat_TH5_P58_IntroduceLocalExtension.Before
{
    public class Report
    {
        public void Process()
        {
            DateTime today = DateTime.Now;
            // Không có hàm NextWeek, phải viết thủ công rất dài
            DateTime nextWeek = new DateTime(today.Year, today.Month, today.Day).AddDays(7);

            Console.WriteLine("Tuần sau là: " + nextWeek.ToString("dd/MM/yyyy"));
        }
    }
}