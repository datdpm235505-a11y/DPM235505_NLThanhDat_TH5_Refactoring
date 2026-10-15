using System;

namespace DPM235505_NLThanhDat_TH5_P37_ReplaceInheritanceWithDelegation.Real
{
    public class DonHang
    {
        // Đơn hàng KHÔNG PHẢI là một Hệ thống thanh toán (không được kế thừa). Nó SỬ DỤNG hệ thống TT.
        private HeThongThanhToan _thanhToan = new HeThongThanhToan();

        public void XuLyDonHang(string tenKhach, double tien)
        {
            if (_thanhToan.KiemTraSoDu(tien))
            {
                Console.WriteLine($"Đơn hàng của {tenKhach} ({tien:N0} VNĐ) đã được thanh toán thành công.");
            }
        }
    }
}