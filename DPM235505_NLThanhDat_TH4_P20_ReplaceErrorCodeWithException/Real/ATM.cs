using System;

namespace DPM235505_NLThanhDat_TH4_P20_ReplaceErrorCodeWithException.Real
{
    public class ATM
    {
        private double _soDuTaiKhoan = 5000000; // 5 triệu

        public void RutTien(double soTien)
        {
            if (soTien > _soDuTaiKhoan)
            {
                throw new InvalidOperationException($"Lỗi: Bạn chỉ còn {_soDuTaiKhoan:N0} VNĐ, không thể rút {soTien:N0} VNĐ.");
            }

            _soDuTaiKhoan -= soTien;
            Console.WriteLine($"Rút thành công {soTien:N0} VNĐ. Số dư còn lại: {_soDuTaiKhoan:N0} VNĐ");
        }
    }
}