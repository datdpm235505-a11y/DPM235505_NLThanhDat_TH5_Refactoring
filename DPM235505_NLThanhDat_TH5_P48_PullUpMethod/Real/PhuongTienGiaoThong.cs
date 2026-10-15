using System;

namespace DPM235505_NLThanhDat_TH5_P48_PullUpMethod.Real
{
    public class PhuongTienGiaoThong
    {
        public string TenPhuongTien { get; set; } = "";

        // Hàm khởi động đều giống nhau: Cấp điện và nổ máy
        public void KhoiDongMay()
        {
            Console.WriteLine($"{TenPhuongTien}: Hệ thống điện đã bật, động cơ khởi động!");
        }
    }

    public class XeOto : PhuongTienGiaoThong { }

    public class XeMay : PhuongTienGiaoThong { }
}