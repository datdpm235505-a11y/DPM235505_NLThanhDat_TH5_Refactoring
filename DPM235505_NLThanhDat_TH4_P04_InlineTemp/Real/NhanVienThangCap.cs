using System;

namespace DPM235505_NLThanhDat_TH4_P04_InlineTemp.Real
{
    public class NhanVienThangCap
    {
        private int _namVaoLam;

        public NhanVienThangCap(int namVaoLam)
        {
            _namVaoLam = namVaoLam;
        }

        public int TinhSoNamKinhNghiem()
        {
            return DateTime.Now.Year - _namVaoLam;
        }

        public void KiemTraThangCap(string tenNV)
        {
            // Thay vì khai báo: int kinhNghiem = TinhSoNamKinhNghiem();
            // Ta gọi trực tiếp hàm (inline) vào câu điều kiện if
            if (TinhSoNamKinhNghiem() >= 3)
            {
                Console.WriteLine($"Nhân viên {tenNV} (Thâm niên: {TinhSoNamKinhNghiem()} năm): ĐỦ ĐIỀU KIỆN thăng cấp.");
            }
            else
            {
                Console.WriteLine($"Nhân viên {tenNV} (Thâm niên: {TinhSoNamKinhNghiem()} năm): CHƯA đủ điều kiện.");
            }
        }
    }
}