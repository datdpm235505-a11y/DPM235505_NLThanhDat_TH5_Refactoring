using System;

namespace DPM235505_NLThanhDat_TH5_P44_ParameterizeMethod.Real
{
    public class ThanhToanHoaDon
    {
        public double TongTien { get; set; }

        // Thay vì viết hàm GiamGiaLe(), GiamGiaTet(). Ta dùng tham số.
        public void ApDungMaGiamGia(double phanTramGiam)
        {
            double tienGiam = TongTien * (phanTramGiam / 100);
            TongTien -= tienGiam;
            Console.WriteLine($"Đã giảm {phanTramGiam}% (-{tienGiam:N0} VNĐ). Cần thanh toán: {TongTien:N0} VNĐ");
        }
    }
}