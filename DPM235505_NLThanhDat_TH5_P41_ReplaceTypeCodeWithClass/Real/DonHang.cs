using System;

namespace DPM235505_NLThanhDat_TH5_P41_ReplaceTypeCodeWithClass.Real
{
    public class DonHang
    {
        public string MaDH { get; set; } = "";
        public TrangThaiDonHang TrangThai { get; set; } = TrangThaiDonHang.ChoDuyet;

        public void InDonHang()
        {
            Console.WriteLine($"Đơn hàng {MaDH} - Trạng thái: {TrangThai.LayTenTrangThai()}");
        }
    }
}