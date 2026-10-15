namespace DPM235505_NLThanhDat_TH5_P41_ReplaceTypeCodeWithClass.After
{
    // Tạo class định nghĩa rạch ròi các nhóm máu (Giống cách hđ của Enum)
    public class BloodGroup
    {
        public static readonly BloodGroup O = new BloodGroup("O");
        public static readonly BloodGroup A = new BloodGroup("A");
        public static readonly BloodGroup B = new BloodGroup("B");
        public static readonly BloodGroup AB = new BloodGroup("AB");

        private string _name;
        private BloodGroup(string name) { _name = name; }
        public string GetName() => _name;
    }
}