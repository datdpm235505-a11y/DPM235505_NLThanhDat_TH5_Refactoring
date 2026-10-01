namespace DPM235505_NLThanhDat_TH4_P19_ReplaceMagicNumber.Before
{
    public class Physics
    {
        public double PotentialEnergy(double mass, double height)
        {
            // Số 9.81 là một "Magic Number", người khác đọc sẽ không hiểu nó là gì
            return mass * 9.81 * height;
        }
    }
}