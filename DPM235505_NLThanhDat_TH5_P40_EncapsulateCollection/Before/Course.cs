using System.Collections.Generic;

namespace DPM235505_NLThanhDat_TH5_P40_EncapsulateCollection.Before
{
    public class Course
    {
        public string Name { get; set; } = "";
        public bool IsAdvanced { get; set; }
    }

    public class Person
    {
        // Public list, ai ở ngoài class cũng tự ý Add, Remove khóa học được
        public List<Course> Courses { get; set; } = new List<Course>();
    }
}