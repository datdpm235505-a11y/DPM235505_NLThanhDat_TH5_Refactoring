using System;

namespace DPM235505_NLThanhDat_TH4_P24_RemoveControlFlag.Before
{
    public class Searcher
    {
        public void CheckSecurity(string[] people)
        {
            // Sử dụng Cờ điều khiển (Control Flag)
            bool found = false;
            for (int i = 0; i < people.Length; i++)
            {
                if (!found)
                {
                    if (people[i] == "Don" || people[i] == "John")
                    {
                        Console.WriteLine("Cảnh báo: Phát hiện đối tượng tình nghi " + people[i]);
                        found = true; // Bật cờ để vòng lặp sau không chạy nữa
                    }
                }
            }
        }
    }
}