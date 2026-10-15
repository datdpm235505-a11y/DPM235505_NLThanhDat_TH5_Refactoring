namespace DPM235505_NLThanhDat_TH5_P37_ReplaceInheritanceWithDelegation.After
{
    public class MyStackRefactored
    {
        // Thay vì kế thừa, ta tạo đối tượng (Ủy quyền)
        private MyVectorRefactored _vector = new MyVectorRefactored();

        public void Push(object obj) { /* ... */ }
        public object Pop() => new object();

        public bool IsEmpty() => _vector.IsEmpty();
    }
}