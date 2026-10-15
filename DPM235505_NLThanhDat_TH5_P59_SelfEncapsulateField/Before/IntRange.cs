namespace DPM235505_NLThanhDat_TH5_P59_SelfEncapsulateField.Before
{
    public class IntRange
    {
        private int _low;
        private int _high;

        public IntRange(int low, int high)
        {
            _low = low;
            _high = high;
        }

        public bool Includes(int arg)
        {
            // Truy cập trực tiếp biến _low, _high. 
            // Nếu sau này muốn thêm logic "báo log khi kiểm tra", ta phải đi sửa mọi chỗ có gọi _low.
            return arg >= _low && arg <= _high;
        }
    }
}