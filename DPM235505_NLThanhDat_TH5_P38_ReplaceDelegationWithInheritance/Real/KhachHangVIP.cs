using System;

namespace DPM235505_NLThanhDat_TH5_P38_ReplaceDelegationWithInheritance.Real
{
    // VIP hiển nhiên là một Khách Hàng (có thông tin cơ bản)
    public class KhachHangVIP : ThongTinCoBan
    {
        public double DiemTichLuy { get; set; }

        public void InThongTinVIP()
        {
            Console.WriteLine($"VIP: {HoTen} | SĐT: {SDT} | Điểm tích lũy: {DiemTichLuy}");
        }
    }
}