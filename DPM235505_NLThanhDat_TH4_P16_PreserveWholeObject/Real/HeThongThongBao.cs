using System;

namespace DPM235505_NLThanhDat_TH4_P16_PreserveWholeObject.Real
{
    public class HeThongThongBao
    {
        // Truyền thẳng đối tượng ThongTinLienHe vào thay vì truyền 2 biến email và sdt
        public void GuiThongBao(string tenNV, ThongTinLienHe lienHe)
        {
            Console.WriteLine($"Đang gửi SMS đến SĐT: {lienHe.SoDienThoai}");
            Console.WriteLine($"Đang gửi Email đến: {lienHe.Email}");
            Console.WriteLine($"=> Đã thông báo thành công cho nhân viên {tenNV}!");
        }
    }
}