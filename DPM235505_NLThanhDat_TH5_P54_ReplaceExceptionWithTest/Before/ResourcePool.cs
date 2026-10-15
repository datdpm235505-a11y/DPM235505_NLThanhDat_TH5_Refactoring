using System;
using System.Collections.Generic;

namespace DPM235505_NLThanhDat_TH5_P54_ReplaceExceptionWithTest.Before
{
    public class ResourcePool
    {
        private Stack<string> _resources = new Stack<string>();

        public string GetResource()
        {
            try
            {
                // Pop() sẽ ném Exception nếu Stack rỗng
                return _resources.Pop();
            }
            catch (InvalidOperationException)
            {
                // Dùng Exception để xử lý luồng logic bình thường là sai chuẩn
                return "Hết tài nguyên";
            }
        }
    }
}