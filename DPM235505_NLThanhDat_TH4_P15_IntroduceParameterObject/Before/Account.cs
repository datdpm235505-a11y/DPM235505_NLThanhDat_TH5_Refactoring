using System;

namespace DPM235505_NLThanhDat_TH4_P15_IntroduceParameterObject.Before
{
    public class Account
    {
        // Hàm nhận quá nhiều tham số ngày tháng rời rạc
        public void GetFlowBetween(DateTime start, DateTime end)
        {
            Console.WriteLine($"Lấy dữ liệu giao dịch từ {start:dd/MM/yyyy} đến {end:dd/MM/yyyy}");
        }
    }
}