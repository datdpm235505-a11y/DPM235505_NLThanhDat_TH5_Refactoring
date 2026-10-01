using System;
namespace DPM235505_NLThanhDat_TH4_P10_ExtractClass.Real
{
    public class NhanVien
    {
        // Gán giá trị mặc định là chuỗi rỗng
        public string TenNV { get; set; } = "";
        public DiaChi DiaChiNha { get; set; } = new DiaChi();

        public void InThongTin()
        {
            Console.WriteLine($"Nhân viên: {TenNV} | Địa chỉ: {DiaChiNha.LayDiaChiDayDu()}");
        }
    }
}