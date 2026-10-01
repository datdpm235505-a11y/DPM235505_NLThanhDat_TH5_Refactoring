using System;
using System.Diagnostics;

namespace DPM235505_NLThanhDat_TH4_P18_IntroduceAssertion.Real
{
    public class KiemTraDoanhThu
    {
        public void XuLyDoanhThu(string tenCuaHang, double doanhThu)
        {
            // Khẳng định doanh thu không bao giờ được là số âm
            Debug.Assert(doanhThu >= 0, "Lỗi nghiêm trọng: Doanh thu bị âm!");

            Console.WriteLine($"Cửa hàng {tenCuaHang} có doanh thu hợp lệ: {doanhThu:N0} VNĐ");
        }
    }
}