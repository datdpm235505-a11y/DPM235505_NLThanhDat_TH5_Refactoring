using System;
namespace DPM235505_NLThanhDat_TH4_P08_ReplaceMethodWithMethodObject.Real
{
    // Đưa logic tính thưởng Tết phức tạp ra 1 class riêng biệt
    public class TinhThuongTetCalculator
    {
        private double _luongCB; private int _thangLamViec; private double _kpi;
        public TinhThuongTetCalculator(double luongCB, int thangLamViec, double kpi)
        {
            _luongCB = luongCB; _thangLamViec = thangLamViec; _kpi = kpi;
        }
        public double TinhToan()
        {
            double thuongCoSo = (_luongCB / 12) * _thangLamViec;
            double heSoThuong = _kpi > 90 ? 1.5 : 1.0;
            return thuongCoSo * heSoThuong;
        }
    }

    public class NhanVienThuongTet
    {
        public void InThuongTet(string tenNV, double luongCB, int thangLamViec, double kpi)
        {
            // Ủy quyền việc tính toán cho Class phụ
            double thuong = new TinhThuongTetCalculator(luongCB, thangLamViec, kpi).TinhToan();
            Console.WriteLine($"Nhân viên {tenNV} nhận thưởng Tết: {thuong:N0} VNĐ");
        }
    }
}