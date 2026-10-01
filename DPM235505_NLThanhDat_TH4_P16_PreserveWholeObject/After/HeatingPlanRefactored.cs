using System;

namespace DPM235505_NLThanhDat_TH4_P16_PreserveWholeObject.After
{
    public class HeatingPlanRefactored
    {
        // Nhận luôn cả đối tượng RoomTempRefactored
        public void CheckTemperature(RoomTempRefactored room)
        {
            Console.WriteLine($"Nhiệt độ nằm trong khoảng: {room.Lowest}°C - {room.Highest}°C");
        }
    }
}