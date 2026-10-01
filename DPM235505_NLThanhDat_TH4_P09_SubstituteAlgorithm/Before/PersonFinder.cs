namespace DPM235505_NLThanhDat_TH4_P09_SubstituteAlgorithm.Before
{
    public class PersonFinder
    {
        public string FoundPerson(string[] people)
        {
            // Thuật toán thủ công dài dòng
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].Equals("Don")) return "Don";
                if (people[i].Equals("John")) return "John";
                if (people[i].Equals("Kent")) return "Kent";
            }
            return string.Empty;
        }
    }
}