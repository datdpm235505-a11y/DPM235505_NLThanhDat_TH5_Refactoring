using System;

namespace DPM235505_NLThanhDat_TH5_P58_IntroduceLocalExtension.Real
{
    public class HienThiGiaTien
    {
        public void InBaoGia()
        {
            double giaLapTrinh = 15000000; // 15 triệu

            // Gọi ToVND() trực tiếp từ biến double (Cực kỳ sạch sẽ)
            Console.WriteLine($"Báo giá dự án: {giaLapTrinh.ToVND()}");
        }
    }
}