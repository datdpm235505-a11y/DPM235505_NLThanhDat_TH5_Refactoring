using System;

namespace DPM235505_NLThanhDat_TH4_P25_ReplaceNestedConditional.Real
{
    public class TinhTienThuong
    {
        public void ThuongNhanVien(string tenNV, bool daNghiViec, bool dangNghiPhep, int soNgayLam)
        {
            // Loại trừ sớm các trường hợp không được thưởng
            if (daNghiViec)
            {
                Console.WriteLine($"{tenNV}: Đã nghỉ việc, không có thưởng.");
                return;
            }
            if (dangNghiPhep)
            {
                Console.WriteLine($"{tenNV}: Đang nghỉ phép, không có thưởng.");
                return;
            }

            // Xử lý luồng chính
            double tienThuong = soNgayLam * 100000;
            Console.WriteLine($"{tenNV}: Được nhận thưởng {tienThuong:N0} VNĐ.");
        }
    }
}