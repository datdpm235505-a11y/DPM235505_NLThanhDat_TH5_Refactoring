namespace DPM235505_NLThanhDat_TH5_P43_ReplaceSubclassWithFields.After
{
    public class PersonRefactored
    {
        private readonly char _code;

        // Truyền thẳng mã 'M' hay 'F' qua Constructor, không cần tạo Class con nữa
        public PersonRefactored(char code)
        {
            _code = code;
        }

        public char GetCode() => _code;

        // Cung cấp các hàm tạo tĩnh cho dễ gọi
        public static PersonRefactored CreateMale() => new PersonRefactored('M');
        public static PersonRefactored CreateFemale() => new PersonRefactored('F');
    }
}