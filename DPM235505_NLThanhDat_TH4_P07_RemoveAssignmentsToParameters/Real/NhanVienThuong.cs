using System;

namespace DPM235505_NLThanhDat_TH4_P07_RemoveAssignmentsToParameters.Real
{
    public class NhanVienThuong
    {
        public void TinhTienThuong(string tenNV, double thuongCoBan, int diemKPI)
        {
            // Tạo biến cục bộ hứng giá trị, bảo toàn tham số thuongCoBan gốc
            double thuongThucTe = thuongCoBan;

            if (diemKPI >= 90)
            {
                thuongThucTe += 500000; // Thưởng thêm 500k
            }
            else if (diemKPI < 50)
            {
                thuongThucTe -= 200000; // Phạt 200k
            }

            Console.WriteLine($"Nhân viên {tenNV} (KPI: {diemKPI})");
            Console.WriteLine($"+ Thưởng cơ sở: {thuongCoBan:N0} VNĐ");
            Console.WriteLine($"+ Tiền thưởng thực tế nhận: {thuongThucTe:N0} VNĐ\n");
        }
    }
}