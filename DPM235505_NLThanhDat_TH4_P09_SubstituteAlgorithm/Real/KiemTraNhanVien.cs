using System;
using System.Collections.Generic;
namespace DPM235505_NLThanhDat_TH4_P09_SubstituteAlgorithm.Real
{
    public class KiemTraNhanVien
    {
        public void KiemTraNhanVienUuTu(string tenNV)
        {
            // Thay vì dùng nhiều lệnh if (ten == "A" || ten == "B" ...), dùng List.Contains
            List<string> danhSachUuTu = new List<string> { "Thành Đạt", "Nguyễn A", "Trần B" };

            if (danhSachUuTu.Contains(tenNV))
                Console.WriteLine($"=> {tenNV} LÀ Nhân viên ưu tú tháng này!");
            else
                Console.WriteLine($"=> {tenNV} không có tên trong danh sách ưu tú.");
        }
    }
}