using System;

namespace DPM235505_NLThanhDat_TH5_P46_SeparateQueryFromModifier.Before
{
    public class Security
    {
        public string FindMiscreant(string[] people)
        {
            foreach (var person in people)
            {
                if (person == "Don")
                {
                    SendAlert(); // Hành động (Modifier) bị trộn vào hàm Truy vấn
                    return "Don";
                }
            }
            return "";
        }

        private void SendAlert() => Console.WriteLine("CẢNH BÁO BẢO MẬT!");
    }
}