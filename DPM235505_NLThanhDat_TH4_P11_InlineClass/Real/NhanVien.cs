using System;

namespace DPM235505_NLThanhDat_TH4_P11_InlineClass.Real
{
    public class NhanVien
    {
        public string TenNV { get; set; } = "";
        public string TenChucVu { get; set; } = "";

        public void InThongTin()
        {
            Console.WriteLine($"Nhân viên: {TenNV} - Chức vụ: {TenChucVu}");
        }
    }
}