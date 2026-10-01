using System;

namespace DPM235505_NLThanhDat_TH4_P15_IntroduceParameterObject.Real
{
    public class KyHanTruyVan
    {
        public DateTime TuNgay { get; set; }
        public DateTime DenNgay { get; set; }

        public KyHanTruyVan(DateTime tuNgay, DateTime denNgay)
        {
            TuNgay = tuNgay;
            DenNgay = denNgay;
        }
    }
}