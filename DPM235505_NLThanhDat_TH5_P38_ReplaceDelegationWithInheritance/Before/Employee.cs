namespace DPM235505_NLThanhDat_TH5_P38_ReplaceDelegationWithInheritance.Before
{
    public class Employee
    {
        // Nhân viên là một Con người. Việc ủy quyền ở đây là rườm rà.
        private Person _person = new Person();

        public string Name
        {
            get => _person.Name;
            set => _person.Name = value;
        }

        public string GetName() => _person.GetName();
    }
}