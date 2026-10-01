namespace DPM235505_NLThanhDat_TH4_P26_ReplaceConditionalWithPolymorphism.After
{
    // Class cha trừu tượng
    public abstract class BirdRefactored
    {
        public abstract double GetSpeed();
    }

    // Các class con kế thừa và tự định nghĩa tốc độ riêng
    public class EuropeanBird : BirdRefactored
    {
        public override double GetSpeed() => 10;
    }

    public class AfricanBird : BirdRefactored
    {
        public override double GetSpeed() => 15;
    }
}