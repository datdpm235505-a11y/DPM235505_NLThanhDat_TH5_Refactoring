using System;

namespace DPM235505_NLThanhDat_TH5_P46_SeparateQueryFromModifier.Real
{
    public class QuanLyKho
    {
        public int TonKho { get; set; } = 10;

        // Hàm 1: Chỉ kiểm tra tồn kho (Query)
        public bool CoTheXuatKho(int soLuongYeuCau)
        {
            return TonKho >= soLuongYeuCau;
        }

        // Hàm 2: Hành động xuất kho (Modifier)
        public void XuatKho(int soLuongYeuCau)
        {
            if (CoTheXuatKho(soLuongYeuCau))
            {
                TonKho -= soLuongYeuCau;
                Console.WriteLine($"Đã xuất {soLuongYeuCau} sản phẩm. Tồn kho còn: {TonKho}");
            }
            else
            {
                Console.WriteLine("Lỗi: Không đủ hàng tồn kho!");
            }
        }
    }
}