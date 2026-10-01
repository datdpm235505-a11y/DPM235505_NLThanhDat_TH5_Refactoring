using System;

namespace DPM235505_NLThanhDat_TH4_P29_ReplaceArrayWithObject.Before
{
    public class Tournament
    {
        public void ShowTeamInfo()
        {
            // Dùng mảng string để lưu lộn xộn cả tên lẫn số trận thắng
            string[] row = new string[2];
            row[0] = "Liverpool";
            row[1] = "15";

            Console.WriteLine($"Đội {row[0]} có {row[1]} trận thắng.");
        }
    }
}