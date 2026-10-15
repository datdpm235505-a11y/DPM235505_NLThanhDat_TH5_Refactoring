namespace DPM235505_NLThanhDat_TH5_P56_ChangeValueToReference.Real
{
    public class HoaDonBanHang
    {
        public ThongTinKhach KhachHang { get; set; }

        public HoaDonBanHang(string sdt, string hoTen)
        {
            KhachHang = KhoDuLieuKhachHang.LayKhachHang(sdt, hoTen);
        }
    }
}