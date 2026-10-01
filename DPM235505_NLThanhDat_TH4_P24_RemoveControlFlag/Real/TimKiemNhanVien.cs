using System;

namespace DPM235505_NLThanhDat_TH4_P24_RemoveControlFlag.Real
{
    public class TimKiemNhanVien
    {
        public void TimNhanVienXuatSac(string[] danhSach)
        {
            foreach (string tenNV in danhSach)
            {
                if (tenNV == "Thành Đạt")
                {
                    Console.WriteLine("=> Đã tìm thấy nhân viên xuất sắc: Thành Đạt!");
                    // Tìm thấy là dừng luôn, không cần quét tiếp danh sách
                    break;
                }
                Console.WriteLine($"Đang duyệt: {tenNV}...");
            }
        }
    }
}