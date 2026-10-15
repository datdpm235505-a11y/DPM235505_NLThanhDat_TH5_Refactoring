namespace DPM235505_NLThanhDat_TH5_P47_PullUpField.Real
{
    public class ConNguoi
    {
        // Các thuộc tính cơ bản của người đều kéo lên đây
        public string HoTen { get; set; } = "";
        public string CMND_CCCD { get; set; } = "";
    }

    public class HocSinh : ConNguoi
    {
        public string TruongHoc { get; set; } = "";
    }

    public class GiaoVien : ConNguoi
    {
        public string MonGiangDay { get; set; } = "";
    }
}