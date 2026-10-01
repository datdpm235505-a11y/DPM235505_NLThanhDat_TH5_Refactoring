using System;

namespace DPM235505_NLThanhDat_TH4_P21_DecomposeConditional.Real
{
    public class GiaVePhim
    {
        public void TinhTienVe(DayOfWeek ngayXem, int soLuongVe)
        {
            double tongTien = LaNgayCuoiTuan(ngayXem) ? TinhGiaCuoiTuan(soLuongVe) : TinhGiaNgayThuong(soLuongVe);
            Console.WriteLine($"Ngày xem: {ngayXem} | Số lượng: {soLuongVe} vé => Tổng tiền: {tongTien:N0} VNĐ");
        }

        private bool LaNgayCuoiTuan(DayOfWeek ngay) => ngay == DayOfWeek.Saturday || ngay == DayOfWeek.Sunday;
        private double TinhGiaCuoiTuan(int soLuong) => soLuong * 120000;
        private double TinhGiaNgayThuong(int soLuong) => soLuong * 80000;
    }
}