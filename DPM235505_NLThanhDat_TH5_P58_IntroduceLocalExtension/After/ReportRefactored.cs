using System;

namespace DPM235505_NLThanhDat_TH5_P58_IntroduceLocalExtension.After
{
    public class ReportRefactored
    {
        public void Process()
        {
            DateTime today = DateTime.Now;
            // Class DateTime lúc này đã "mọc" thêm hàm NextWeek() cứ như hàm gốc của nó
            DateTime nextWeek = today.NextWeek();

            Console.WriteLine("Tuần sau là: " + nextWeek.ToString("dd/MM/yyyy"));
        }
    }
}