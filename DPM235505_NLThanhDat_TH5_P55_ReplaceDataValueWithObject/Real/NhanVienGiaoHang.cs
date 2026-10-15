using System;

namespace DPM235505_NLThanhDat_TH5_P55_ReplaceDataValueWithObject.Real
{
    public class NhanVienGiaoHang
    {
        public string TenNV { get; set; } = "";

        // Thay vì 2 biến string rải rác, dùng hẳn Object DiaChi
        public DiaChi DiaChiGiao { get; set; } = new DiaChi();

        public void InPhieuGiao()
        {
            Console.WriteLine($"Người giao: {TenNV} | Tuyến: {DiaChiGiao.LayDiaChiDayDu()}");
        }
    }
}