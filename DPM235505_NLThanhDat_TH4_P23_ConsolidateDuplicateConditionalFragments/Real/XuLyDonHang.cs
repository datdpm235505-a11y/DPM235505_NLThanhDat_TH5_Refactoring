using System;

namespace DPM235505_NLThanhDat_TH4_P23_ConsolidateDuplicateConditionalFragments.Real
{
    public class XuLyDonHang
    {
        public void ThanhToan(string tenKhachHang, double tongTien, bool laVip)
        {
            double tienPhaiTra;

            if (laVip)
            {
                tienPhaiTra = tongTien - (tongTien * 0.2); // VIP giảm 20%
            }
            else
            {
                tienPhaiTra = tongTien; // Bình thường không giảm
            }

            // Đoạn In biên lai lúc nào cũng phải chạy, nên mang ra ngoài
            Console.WriteLine($"Khách hàng: {tenKhachHang}");
            Console.WriteLine($"=> Số tiền thanh toán: {tienPhaiTra:N0} VNĐ\n");
        }
    }
}