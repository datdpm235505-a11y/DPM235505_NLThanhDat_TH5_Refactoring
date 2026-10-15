using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DPM235505_NLThanhDat_TH5_P40_EncapsulateCollection.After
{
    public class CourseRefactored
    {
        public string Name { get; set; } = "";
        public bool IsAdvanced { get; set; }
    }

    public class PersonRefactored
    {
        private List<CourseRefactored> _courses = new List<CourseRefactored>();

        // Chỉ trả về dạng ReadOnly, không cho phép Add/Remove trực tiếp từ List này
        public ReadOnlyCollection<CourseRefactored> Courses => _courses.AsReadOnly();

        // Cung cấp hàm Add chính thống
        public void AddCourse(CourseRefactored course)
        {
            _courses.Add(course);
        }

        public void RemoveCourse(CourseRefactored course)
        {
            _courses.Remove(course);
        }
    }
}