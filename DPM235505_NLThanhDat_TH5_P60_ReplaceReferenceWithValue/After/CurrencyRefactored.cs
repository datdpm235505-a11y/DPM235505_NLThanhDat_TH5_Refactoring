namespace DPM235505_NLThanhDat_TH5_P60_ReplaceReferenceWithValue.After
{
    public class CurrencyRefactored
    {
        // Bỏ setter. Làm cho Object trở nên Bất biến (Immutable)
        public string Code { get; }

        public CurrencyRefactored(string code)
        {
            Code = code;
        }

        // Với Value Object, phải tự định nghĩa lại quy tắc so sánh Bằng (Equals)
        public override bool Equals(object? obj)
        {
            if (obj is CurrencyRefactored other)
                return Code == other.Code;
            return false;
        }

        public override int GetHashCode() => Code.GetHashCode();
    }
}