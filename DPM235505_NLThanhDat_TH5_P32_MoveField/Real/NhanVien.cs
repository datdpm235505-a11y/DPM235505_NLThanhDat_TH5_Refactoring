using System;

namespace DPM235505_NLThanhDat_TH5_P32_MoveField.Real
{
    public class NhanVien
    {
        public string TenNV { get; set; } = "";
        public ChucVu ChucVuNhanVien { get; set; } = new ChucVu();

        public void InPhuCap()
        {
            Console.WriteLine($"Nhân viên: {TenNV}");
            Console.WriteLine($"Chức vụ: {ChucVuNhanVien.TenChucVu}");
            Console.WriteLine($"Phụ cấp đảm nhận: {ChucVuNhanVien.PhuCapChucVu:N0} VNĐ\n");
        }
    }
}