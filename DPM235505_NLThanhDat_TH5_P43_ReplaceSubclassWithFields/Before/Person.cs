namespace DPM235505_NLThanhDat_TH5_P43_ReplaceSubclassWithFields.Before
{
    public abstract class Person
    {
        public abstract char GetCode();
    }

    public class Male : Person
    {
        public override char GetCode() => 'M';
    }

    public class Female : Person
    {
        public override char GetCode() => 'F';
    }
}