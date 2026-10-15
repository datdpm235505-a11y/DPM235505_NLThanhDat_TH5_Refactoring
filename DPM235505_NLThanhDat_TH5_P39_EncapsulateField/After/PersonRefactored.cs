using System;

namespace DPM235505_NLThanhDat_TH5_P39_EncapsulateField.After
{
    public class PersonRefactored
    {
        // Chuyển thành private để bảo vệ dữ liệu
        private string _name = "";

        // Cung cấp Property để kiểm soát dữ liệu đầu vào
        public string Name
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _name = value;
                else
                    Console.WriteLine("Lỗi: Tên không được để trống!");
            }
        }
    }
}