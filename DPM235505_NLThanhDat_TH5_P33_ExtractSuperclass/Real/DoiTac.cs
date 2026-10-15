using System;

namespace DPM235505_NLThanhDat_TH5_P33_ExtractSuperclass.Real
{
    public class DoiTac : DoiTuongNhanSu
    {
        public string TenCongTy { get; set; } = "";

        public override void InRole()
        {
            Console.WriteLine($"[Đối tác] {HoTen} (Mã: {MaSo}) - Công ty: {TenCongTy}");
        }
    }
}