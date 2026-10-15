using System;

namespace DPM235505_NLThanhDat_TH5_P51_HideMethod.Real
{
    public class MayPhaCaPhe
    {
        public void PhaCaPhe()
        {
            DunSoiNuoc();
            XayHatCaPhe();
            Console.WriteLine("=> Cà phê của bạn đã sẵn sàng!");
        }

        // Các bước này khách hàng bên ngoài không cần tự gọi, nên ẩn đi (private)
        private void DunSoiNuoc()
        {
            Console.WriteLine("- Đang đun sôi nước...");
        }

        private void XayHatCaPhe()
        {
            Console.WriteLine("- Đang xay hạt cà phê...");
        }
    }
}