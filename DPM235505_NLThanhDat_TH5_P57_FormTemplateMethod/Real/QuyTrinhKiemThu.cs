using System;

namespace DPM235505_NLThanhDat_TH5_P57_FormTemplateMethod.Real
{
    public abstract class QuyTrinhKiemThu
    {
        // Khuôn mẫu quy trình test phần mềm
        public void ChayKiemThu()
        {
            Console.WriteLine("1. Mở phần mềm...");
            ThucHienTest();
            XuatBaoCao();
            Console.WriteLine("4. Đóng phần mềm.\n");
        }

        protected abstract void ThucHienTest();

        private void XuatBaoCao() => Console.WriteLine("3. Tự động xuất báo cáo Log.");
    }

    public class KiemThuGiaoDien : QuyTrinhKiemThu
    {
        protected override void ThucHienTest() => Console.WriteLine("2. Click các nút bấm trên UI (Giao diện).");
    }

    public class KiemThuBaoMat : QuyTrinhKiemThu
    {
        protected override void ThucHienTest() => Console.WriteLine("2. Chạy script dò lỗ hổng bảo mật SQL Injection.");
    }
}