using System.Collections.Generic;

namespace DPM235505_NLThanhDat_TH5_P54_ReplaceExceptionWithTest.After
{
    public class ResourcePoolRefactored
    {
        private Stack<string> _resources = new Stack<string>();

        public string GetResource()
        {
            // Kiểm tra bằng IF (Test) trước, thay vì đợi lỗi nổ ra rồi Catch
            if (_resources.Count == 0)
            {
                return "Hết tài nguyên";
            }
            return _resources.Pop();
        }
    }
}