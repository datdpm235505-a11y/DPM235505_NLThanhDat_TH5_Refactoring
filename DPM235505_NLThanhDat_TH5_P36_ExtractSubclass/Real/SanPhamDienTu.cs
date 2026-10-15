using System;

namespace DPM235505_NLThanhDat_TH5_P36_ExtractSubclass.Real
{
    // Tách riêng SP Điện tử vì nó có thêm thuộc tính "Thời gian bảo hành" (Trái cây hay Quần áo thì không có)
    public class SanPhamDienTu : SanPham
    {
        public int ThoiGianBaoHanhThang { get; set; }

        public void InThongTin()
        {
            Console.WriteLine($"Sản phẩm: {TenSP} | Giá: {GiaBan:N0} VNĐ | Bảo hành: {ThoiGianBaoHanhThang} tháng");
        }
    }
}