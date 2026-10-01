namespace DPM235505_NLThanhDat_TH4_P19_ReplaceMagicNumber.After
{
    public class PhysicsRefactored
    {
        // Thay thế số 9.81 bằng Hằng số có tên gợi nhớ
        private const double GRAVITATIONAL_CONSTANT = 9.81;

        public double PotentialEnergy(double mass, double height)
        {
            return mass * GRAVITATIONAL_CONSTANT * height;
        }
    }
}