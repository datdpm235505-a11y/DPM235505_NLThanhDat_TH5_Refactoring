using System;

namespace DPM235505_NLThanhDat_TH5_P53_RemoveSettingMethod.Real
{
    public class HoaDon
    {
        // Mã hóa đơn (Invoice ID) cấm tuyệt đối việc chỉnh sửa sau khi xuất
        public string MaHoaDon { get; }
        public double TongTien { get; set; }

        public HoaDon(string maHoaDon, double tongTien)
        {
            MaHoaDon = maHoaDon;
            TongTien = tongTien;
        }

        public void InHoaDon()
        {
            Console.WriteLine($"Hóa đơn số: {MaHoaDon} | Số tiền: {TongTien:N0} VNĐ");
        }
    }
}