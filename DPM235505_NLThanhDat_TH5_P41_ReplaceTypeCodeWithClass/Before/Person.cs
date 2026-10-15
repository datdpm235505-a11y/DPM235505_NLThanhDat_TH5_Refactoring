namespace DPM235505_NLThanhDat_TH5_P41_ReplaceTypeCodeWithClass.Before
{
    public class Person
    {
        // Mã nhóm máu truyền vào bằng int, dễ bị truyền nhầm (vd: truyền số 99)
        public const int O = 0;
        public const int A = 1;
        public const int B = 2;
        public const int AB = 3;

        public int BloodGroup { get; set; }
        public string Name { get; set; } = "";
    }
}