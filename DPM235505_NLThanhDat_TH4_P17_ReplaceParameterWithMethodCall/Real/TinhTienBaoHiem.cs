using System;

namespace DPM235505_NLThanhDat_TH4_P17_ReplaceParameterWithMethodCall.Real
{
    public class TinhTienBaoHiem
    {
        private double _luongCoBan = 15000000;

        public void InThongTinBaoHiem(string tenNV)
        {
            // Bỏ việc khai báo biến tỷ lệ bảo hiểm ở ngoài, để hàm tính toán tự gọi
            double tienDong = TinhTienDongBHXH(_luongCoBan);
            Console.WriteLine($"Nhân viên: {tenNV} | Tiền đóng BHXH: {tienDong:N0} VNĐ");
        }

        private double LayTyLeBHXH() => 0.08; // 8%

        private double TinhTienDongBHXH(double luongCB)
            => luongCB * LayTyLeBHXH(); // Tự gọi hàm lấy tỷ lệ
    }
}