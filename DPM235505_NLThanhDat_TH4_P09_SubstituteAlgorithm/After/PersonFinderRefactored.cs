using System.Collections.Generic;
namespace DPM235505_NLThanhDat_TH4_P09_SubstituteAlgorithm.After
{
    public class PersonFinderRefactored
    {
        public string FoundPerson(string[] people)
        {
            // Thay thế bằng thuật toán danh sách (List) ngắn gọn hơn
            List<string> candidates = new List<string> { "Don", "John", "Kent" };
            foreach (string person in people)
            {
                if (candidates.Contains(person)) return person;
            }
            return string.Empty;
        }
    }
}