using System;

namespace DPM235505_NLThanhDat_TH4_P28_RenameMethod.Real
{
    public class ChamCong
    {
        // Thay vì đặt hàm là TinhNC() rất khó hiểu, ta đổi thành TinhNgayCong()
        public int TinhNgayCong(int ngayDiLam, int ngayNghiPhep)
        {
            return ngayDiLam + ngayNghiPhep;
        }

        public void InBaoCao(string tenNV, int lam, int phep)
        {
            Console.WriteLine($"Nhân viên {tenNV} có tổng ngày công: {TinhNgayCong(lam, phep)} ngày.");
        }
    }
}