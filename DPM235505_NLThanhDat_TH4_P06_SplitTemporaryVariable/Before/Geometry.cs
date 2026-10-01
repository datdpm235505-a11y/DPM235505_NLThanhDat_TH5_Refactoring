using System;

namespace DPM235505_NLThanhDat_TH4_P06_SplitTemporaryVariable.Before
{
    public class Geometry
    {
        public void PrintGeometryDetails(double height, double width)
        {
            // Biến temp được dùng để tính Chu vi
            double temp = 2 * (height + width);
            Console.WriteLine("Chu vi: " + temp);

            // Xong lại tái sử dụng biến temp để tính Diện tích
            temp = height * width;
            Console.WriteLine("Diện tích: " + temp);
        }
    }
}