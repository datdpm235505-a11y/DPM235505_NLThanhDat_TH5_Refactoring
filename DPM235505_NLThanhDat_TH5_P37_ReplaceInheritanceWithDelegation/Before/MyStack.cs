namespace DPM235505_NLThanhDat_TH5_P37_ReplaceInheritanceWithDelegation.Before
{
    // Stack không phải là một Vector (sai logic thiết kế)
    public class MyStack : MyVector
    {
        public void Push(object obj) { /* ... */ }
        public object Pop() => new object();
    }
}