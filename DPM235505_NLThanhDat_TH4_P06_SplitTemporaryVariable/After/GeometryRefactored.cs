using System;

namespace DPM235505_NLThanhDat_TH4_P06_SplitTemporaryVariable.After
{
    public class GeometryRefactored
    {
        public void PrintGeometryDetails(double height, double width)
        {
            // Tách thành biến chuyên tính Chu vi
            double perimeter = 2 * (height + width);
            Console.WriteLine("Chu vi: " + perimeter);

            // Tách thành biến chuyên tính Diện tích (dùng từ khóa khai báo mới)
            double area = height * width;
            Console.WriteLine("Diện tích: " + area);
        }
    }
}