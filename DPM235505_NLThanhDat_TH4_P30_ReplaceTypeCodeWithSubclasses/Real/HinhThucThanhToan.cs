using System;

namespace DPM235505_NLThanhDat_TH4_P30_ReplaceTypeCodeWithSubclasses.Real
{
    // Bỏ mã loại thanh toán (1: Tiền mặt, 2: Thẻ, 3: Chuyển khoản)
    // Thay bằng Lớp con để dễ mở rộng sau này (ví dụ thêm Momo, ZaloPay)
    public abstract class HinhThucThanhToan
    {
        public abstract void TienHanhThanhToan(double soTien);
    }

    public class ThanhToanTienMat : HinhThucThanhToan
    {
        public override void TienHanhThanhToan(double soTien)
        {
            Console.WriteLine($"Đã thu {soTien:N0} VNĐ tiền mặt từ khách.");
        }
    }

    public class ThanhToanChuyenKhoan : HinhThucThanhToan
    {
        public override void TienHanhThanhToan(double soTien)
        {
            Console.WriteLine($"Đang kết nối API Ngân hàng... Đã nhận {soTien:N0} VNĐ qua mã QR.");
        }
    }
}