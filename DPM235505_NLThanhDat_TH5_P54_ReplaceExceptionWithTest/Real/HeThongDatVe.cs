using System;

namespace DPM235505_NLThanhDat_TH5_P54_ReplaceExceptionWithTest.Real
{
    public class HeThongDatVe
    {
        private int _soVeConLai = 1;

        public void MuaVe(string tenKH)
        {
            // Kiểm tra IF thay vì dùng Try-Catch bắt lỗi
            if (_soVeConLai <= 0)
            {
                Console.WriteLine($"Xin lỗi {tenKH}, vé đã bán hết!");
                return;
            }

            _soVeConLai--;
            Console.WriteLine($"{tenKH} đã mua vé thành công. Vé còn lại: {_soVeConLai}");
        }
    }
}