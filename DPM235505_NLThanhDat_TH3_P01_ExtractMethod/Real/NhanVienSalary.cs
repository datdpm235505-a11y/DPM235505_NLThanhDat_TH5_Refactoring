using System;

namespace DPM235505_NLThanhDat_TH4_P01_ExtractMethod.Real
{
    public class NhanVienSalary
    {
        public void XuLyTraLuong(string tenNV, double luongCoBan, int soNgayCong)
        {
            InTieuDePhieuLuong();
            double luongThucTe = TinhLuong(luongCoBan, soNgayCong);
            InBienLai(tenNV, luongThucTe);
        }

        private void InTieuDePhieuLuong()
        {
            Console.WriteLine("=== PHIẾU THANH TOÁN LƯƠNG NHÂN VIÊN ===");
        }

        private double TinhLuong(double luongCB, int ngayCong)
        {
            return (luongCB / 26) * ngayCong;
        }

        private void InBienLai(string ten, double luong)
        {
            Console.WriteLine($"Nhân viên: {ten} | Thực lãnh: {luong:N0} VNĐ\n");
        }
    }
}