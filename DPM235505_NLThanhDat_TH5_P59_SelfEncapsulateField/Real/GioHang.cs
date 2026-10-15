using System;

namespace DPM235505_NLThanhDat_TH5_P59_SelfEncapsulateField.Real
{
    public class GioHang
    {
        private double _tongTien;

        // Cho phép class con (Giỏ hàng VIP) ghi đè logic tính tổng tiền
        protected virtual double TongTien
        {
            get { return _tongTien; }
            set { _tongTien = value; }
        }

        public void ThemSP(double giaTien)
        {
            TongTien += giaTien; // Truy cập qua Property
        }

        public void InThanhToan()
        {
            Console.WriteLine($"Số tiền cần thanh toán: {TongTien:N0} VNĐ");
        }
    }

    public class GioHangVIP : GioHang
    {
        // Ghi đè để tự động giảm 10%
        protected override double TongTien
        {
            get => base.TongTien * 0.9;
            set => base.TongTien = value;
        }
    }
}