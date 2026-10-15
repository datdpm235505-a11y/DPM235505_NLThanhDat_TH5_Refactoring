using System;

namespace DPM235505_NLThanhDat_TH5_P39_EncapsulateField.Real
{
    public class TaiKhoanNganHang
    {
        public string ChuTaiKhoan { get; set; } = "";

        // Tiền trong tài khoản tuyệt đối không được public để người khác tự ý gán (vd: soDu = 1 tỷ)
        private double _soDu;

        public double LaySoDu()
        {
            return _soDu;
        }

        public void NapTien(double soTien)
        {
            if (soTien > 0)
            {
                _soDu += soTien;
                Console.WriteLine($"Đã nạp {soTien:N0} VNĐ. Số dư: {_soDu:N0} VNĐ");
            }
        }
    }
}