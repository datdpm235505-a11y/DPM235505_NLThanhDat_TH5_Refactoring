using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DPM235505_NLThanhDat_TH5_P40_EncapsulateCollection.Real
{
    public class DuAn
    {
        public string TenDuAn { get; set; } = "";

        // Bảo vệ danh sách thành viên
        private List<string> _thanhVien = new List<string>();
        public ReadOnlyCollection<string> ThanhVien => _thanhVien.AsReadOnly();

        public void ThemThanhVien(string tenNV)
        {
            if (!_thanhVien.Contains(tenNV))
            {
                _thanhVien.Add(tenNV);
                Console.WriteLine($"Đã thêm {tenNV} vào dự án {TenDuAn}.");
            }
        }
    }
}