using System;

namespace DPM235505_NLThanhDat_TH4_P14_IntroduceForeignMethod.Real
{
    public class TinhLuong
    {
        public void TinhNgayNhanLuong(string tenNV)
        {
            DateTime ngayChotCong = DateTime.Now;
            DateTime ngayPhatLuong = TinhNgayTraLuong(ngayChotCong);

            Console.WriteLine($"Nhân viên {tenNV} chốt công ngày {ngayChotCong:dd/MM/yyyy}");
            Console.WriteLine($"=> Ngày nhận lương sẽ là: {ngayPhatLuong:dd/MM/yyyy}");
        }

        // Phương thức ngoại lai xử lý logic cộng thêm 5 ngày làm việc
        private static DateTime TinhNgayTraLuong(DateTime ngayChot)
        {
            return ngayChot.AddDays(5);
        }
    }
}