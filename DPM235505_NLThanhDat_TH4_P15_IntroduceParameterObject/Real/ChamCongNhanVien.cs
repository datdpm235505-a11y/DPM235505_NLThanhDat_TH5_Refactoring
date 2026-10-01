using System;

namespace DPM235505_NLThanhDat_TH4_P15_IntroduceParameterObject.Real
{
    public class ChamCongNhanVien
    {
        public void XuatBaoCaoChamCong(string tenNV, KyHanTruyVan kyHan)
        {
            Console.WriteLine($"Nhân viên: {tenNV}");
            Console.WriteLine($"-> Đang xuất báo cáo chấm công từ {kyHan.TuNgay:dd/MM/yyyy} đến {kyHan.DenNgay:dd/MM/yyyy}...");
        }
    }
}