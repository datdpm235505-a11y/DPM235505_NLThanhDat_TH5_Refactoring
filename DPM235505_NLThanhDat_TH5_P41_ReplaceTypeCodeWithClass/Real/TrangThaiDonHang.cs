namespace DPM235505_NLThanhDat_TH5_P41_ReplaceTypeCodeWithClass.Real
{
    public class TrangThaiDonHang
    {
        public static readonly TrangThaiDonHang ChoDuyet = new TrangThaiDonHang("Chờ Duyệt");
        public static readonly TrangThaiDonHang DangGiao = new TrangThaiDonHang("Đang Giao");
        public static readonly TrangThaiDonHang HoanThanh = new TrangThaiDonHang("Hoàn Thành");

        private string _tenTrangThai;
        private TrangThaiDonHang(string ten) { _tenTrangThai = ten; }
        public string LayTenTrangThai() => _tenTrangThai;
    }
}