using System;

namespace DPM235505_NLThanhDat_TH4_P02_InlineMethod.Real
{
    public class NhanVienBonus
    {
        private double _doanhSo;

        public NhanVienBonus(double doanhSo)
        {
            _doanhSo = doanhSo;
        }

        public void DanhGiaThuong(string tenNV)
        {
            // Thay vì tạo 1 hàm bool KiemTraDoanhSo() riêng biệt, 
            // ta gộp luôn logic >= 50 triệu ngay tại đây cho gọn.
            bool duocThuong = _doanhSo >= 50000000;

            if (duocThuong)
                Console.WriteLine($"Nhân viên {tenNV}: Đạt KPI -> ĐƯỢC THƯỞNG!");
            else
                Console.WriteLine($"Nhân viên {tenNV}: Chưa đạt KPI -> KHÔNG ĐƯỢC THƯỞNG.");
        }
    }
}