using System;

namespace DPM235505_NLThanhDat_TH4_P16_PreserveWholeObject.Before
{
    public class HeatingPlan
    {
        // Nhận từng thuộc tính rời rạc (Bad smell)
        public void CheckTemperature(int low, int high)
        {
            Console.WriteLine($"Nhiệt độ nằm trong khoảng: {low}°C - {high}°C");
        }
    }
}