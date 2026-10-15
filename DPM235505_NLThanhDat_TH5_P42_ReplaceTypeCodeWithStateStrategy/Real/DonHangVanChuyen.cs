using System;

namespace DPM235505_NLThanhDat_TH5_P42_ReplaceTypeCodeWithStateStrategy.Real
{
    public class DonHangVanChuyen
    {
        public double TrongLuongKg { get; set; }
        // Có thể linh hoạt đổi từ Giao thường sang Hỏa tốc bất cứ lúc nào
        public HinhThucVanChuyen HinhThuc { get; set; } = new GiaoHangThuong();

        public void InPhiGiaoHang()
        {
            Console.WriteLine($"Phí giao hàng: {HinhThuc.TinhPhi(TrongLuongKg):N0} VNĐ");
        }
    }
}