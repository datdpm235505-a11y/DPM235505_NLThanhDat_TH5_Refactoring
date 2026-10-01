namespace DPM235505_NLThanhDat_TH4_P12_HideDelegate.After
{
    public class PersonRefactored
    {
        public string Name { get; set; } = "";
        private Department _department = new Department();

        public void SetDepartment(Department dept) => _department = dept;

        // Giấu Department đi, tạo hàm lấy trực tiếp Manager
        public string GetManager() => _department.Manager;
    }
}