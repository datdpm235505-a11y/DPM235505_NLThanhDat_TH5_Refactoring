using System;

namespace DPM235505_NLThanhDat_TH5_P45_ReplaceParameterWithExplicitMethods.Real
{
    public class HeThongDen
    {
        // Thay vì dùng hàm ThayDoiTrangThai(bool batTat), ta viết rõ hàm Bat() và Tat()
        public void BatDenNgu()
        {
            Console.WriteLine("Đèn ngủ đã được [BẬT].");
        }

        public void TatDenNgu()
        {
            Console.WriteLine("Đèn ngủ đã được [TẮT].");
        }
    }
}