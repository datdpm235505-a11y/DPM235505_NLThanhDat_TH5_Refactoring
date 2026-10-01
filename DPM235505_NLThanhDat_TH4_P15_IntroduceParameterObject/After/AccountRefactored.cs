using System;

namespace DPM235505_NLThanhDat_TH4_P15_IntroduceParameterObject.After
{
    public class AccountRefactored
    {
        // Truyền 1 đối tượng duy nhất thay vì nhiều tham số rời rạc
        public void GetFlowBetween(DateRange range)
        {
            Console.WriteLine($"Lấy dữ liệu giao dịch từ {range.Start:dd/MM/yyyy} đến {range.End:dd/MM/yyyy}");
        }
    }
}