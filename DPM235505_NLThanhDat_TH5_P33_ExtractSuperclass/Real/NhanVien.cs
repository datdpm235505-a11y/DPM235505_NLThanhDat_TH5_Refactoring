using System;

namespace DPM235505_NLThanhDat_TH5_P33_ExtractSuperclass.Real
{
    public class NhanVien : DoiTuongNhanSu
    {
        public string ChucVu { get; set; } = "";

        public override void InRole()
        {
            Console.WriteLine($"[Nhân viên chính thức] {HoTen} (Mã: {MaSo}) - Chức vụ: {ChucVu}");
        }
    }
}