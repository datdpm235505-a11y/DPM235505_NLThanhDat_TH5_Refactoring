using System;

namespace DPM235505_NLThanhDat_TH4_P29_ReplaceArrayWithObject.Real
{
    public class QuanLyNhanSu
    {
        // Nhận vào 1 đối tượng rành mạch thay vì 1 mảng string[] info
        public void InHoSo(HoSoNhanVien hs)
        {
            Console.WriteLine($"--- HỒ SƠ NHÂN SỰ ---");
            Console.WriteLine($"+ Tên: {hs.HoTen}");
            Console.WriteLine($"+ Vị trí: {hs.ChucVu}");
            Console.WriteLine($"+ Lương: {hs.Luong:N0} VNĐ\n");
        }
    }
}