using System;

namespace DPM235505_NLThanhDat_TH4_P05_ReplaceTempWithQuery.Real
{
    public class NhanVienNetSalary
    {
        private int _soGioLam;
        private double _luongTheoGio;

        public NhanVienNetSalary(int soGioLam, double luongTheoGio)
        {
            _soGioLam = soGioLam;
            _luongTheoGio = luongTheoGio;
        }

        // Hàm truy vấn thay thế cho biến tạm tính lương thô
        private double TinhLuongTho()
        {
            return _soGioLam * _luongTheoGio;
        }

        public void InPhieuLuong(string tenNV)
        {
            double luongThucLanh;

            // Sử dụng hàm truy vấn trực tiếp để ra quyết định trừ thuế
            if (TinhLuongTho() >= 20000000) // Trên 20 triệu phải đóng 10% thuế
            {
                luongThucLanh = TinhLuongTho() * 0.9;
            }
            else
            {
                luongThucLanh = TinhLuongTho();
            }

            Console.WriteLine($"Nhân viên {tenNV}");
            Console.WriteLine($" + Lương thô (Tạm tính): {TinhLuongTho():N0} VNĐ");
            Console.WriteLine($" + Thực lãnh: {luongThucLanh:N0} VNĐ\n");
        }
    }
}