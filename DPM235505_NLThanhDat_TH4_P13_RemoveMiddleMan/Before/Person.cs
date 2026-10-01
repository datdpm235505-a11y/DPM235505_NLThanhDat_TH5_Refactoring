namespace DPM235505_NLThanhDat_TH4_P13_RemoveMiddleMan.Before
{
    public class Person
    {
        private Department _department = new Department();
        public void SetDepartment(Department dept) => _department = dept;

        // Hàm trung gian không cần thiết
        public string GetManager() => _department.Manager;
    }
}