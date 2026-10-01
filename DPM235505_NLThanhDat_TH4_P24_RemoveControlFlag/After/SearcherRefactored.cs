using System;

namespace DPM235505_NLThanhDat_TH4_P24_RemoveControlFlag.After
{
    public class SearcherRefactored
    {
        public void CheckSecurity(string[] people)
        {
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i] == "Don" || people[i] == "John")
                {
                    Console.WriteLine("Cảnh báo: Phát hiện đối tượng tình nghi " + people[i]);
                    break; // Thoát vòng lặp ngay lập tức, bỏ luôn biến cờ (found)
                }
            }
        }
    }
}