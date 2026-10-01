using System;

namespace DPM235505_NLThanhDat_TH4_P21_DecomposeConditional.Before
{
    public class PriceCalculator
    {
        public double CalculateCharge(DateTime date, double quantity)
        {
            double charge;
            // Điều kiện lộn xộn, logic tính toán nằm hết bên trong if/else
            if (date.Month < 6 || date.Month > 8)
            {
                charge = quantity * 10 + 50; // Winter rate
            }
            else
            {
                charge = quantity * 15; // Summer rate
            }
            return charge;
        }
    }
}