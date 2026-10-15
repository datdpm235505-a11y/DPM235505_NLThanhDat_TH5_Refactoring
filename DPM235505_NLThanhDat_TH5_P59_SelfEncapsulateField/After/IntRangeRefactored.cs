namespace DPM235505_NLThanhDat_TH5_P59_SelfEncapsulateField.After
{
    public class IntRangeRefactored
    {
        private int _low;
        private int _high;

        // Tự đóng gói
        protected int Low { get { return _low; } }
        protected int High { get { return _high; } }

        public IntRangeRefactored(int low, int high)
        {
            _low = low;
            _high = high;
        }

        public bool Includes(int arg)
        {
            // Sử dụng thông qua Property thay vì biến _low
            return arg >= Low && arg <= High;
        }
    }
}