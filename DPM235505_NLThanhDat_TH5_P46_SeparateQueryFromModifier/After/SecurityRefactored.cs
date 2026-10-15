using System;

namespace DPM235505_NLThanhDat_TH5_P46_SeparateQueryFromModifier.After
{
    public class SecurityRefactored
    {
        // Hàm 1: Chỉ truy vấn, không thay đổi gì cả
        public string FindMiscreant(string[] people)
        {
            foreach (var person in people)
            {
                if (person == "Don") return "Don";
            }
            return "";
        }

        // Hàm 2: Chỉ thực hiện hành động
        public void SendAlert(string[] people)
        {
            if (FindMiscreant(people) != "")
            {
                Console.WriteLine("CẢNH BÁO BẢO MẬT!");
            }
        }
    }
}