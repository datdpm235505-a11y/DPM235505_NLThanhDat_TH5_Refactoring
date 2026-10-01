using System;

namespace DPM235505_NLThanhDat_TH4_P22_ConsolidateConditionalExpression.Real
{
    public class XetDuyetKhoanVay
    {
        public void KiemTraVayVon(string tenKH, int doTuoi, double thuNhap, bool biNoXau)
        {
            if (KhongDuDieuKienVay(doTuoi, thuNhap, biNoXau))
            {
                Console.WriteLine($"Khách hàng {tenKH}: TỪ CHỐI CHO VAY.");
                return;
            }

            Console.WriteLine($"Khách hàng {tenKH}: ĐỦ ĐIỀU KIỆN CHO VAY!");
        }

        // Gộp tất cả lý do từ chối vào 1 hàm
        private bool KhongDuDieuKienVay(int tuoi, double luong, bool noXau)
        {
            return tuoi < 18 || tuoi > 65 || luong < 5000000 || noXau;
        }
    }
}