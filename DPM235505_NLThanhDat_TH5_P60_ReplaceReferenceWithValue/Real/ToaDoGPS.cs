using System;

namespace DPM235505_NLThanhDat_TH5_P60_ReplaceReferenceWithValue.Real
{
    // Cấu trúc tọa độ không bao giờ được phép sửa đổi sau khi đo (Bất biến)
    public class ToaDoGPS
    {
        public double ViDo { get; } // Read-only
        public double KinhDo { get; } // Read-only

        public ToaDoGPS(double viDo, double kinhDo)
        {
            ViDo = viDo;
            KinhDo = kinhDo;
        }

        public override bool Equals(object? obj)
        {
            if (obj is ToaDoGPS toaDo)
                return ViDo == toaDo.ViDo && KinhDo == toaDo.KinhDo;
            return false;
        }

        public override int GetHashCode() => HashCode.Combine(ViDo, KinhDo);
    }
}