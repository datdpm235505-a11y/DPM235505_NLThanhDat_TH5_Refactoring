using System;
using System.Collections.Generic;

namespace DPM235505_NLThanhDat_TH5_P56_ChangeValueToReference.Real
{
    public static class KhoDuLieuKhachHang
    {
        private static Dictionary<string, ThongTinKhach> _kho = new Dictionary<string, ThongTinKhach>();

        public static ThongTinKhach LayKhachHang(string sdt, string hoTen)
        {
            if (!_kho.ContainsKey(sdt))
            {
                _kho[sdt] = new ThongTinKhach { SDT = sdt, HoTen = hoTen };
                Console.WriteLine($"[Hệ thống] Đã tạo mới hồ sơ KH: {hoTen}");
            }
            return _kho[sdt];
        }
    }
}