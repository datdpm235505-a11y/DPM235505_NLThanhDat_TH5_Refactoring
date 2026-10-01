using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235505_NLThanhDat_TH4_P08_ReplaceMethodWithMethodObject.After
{
    public class Account
    {
        public int Gamma(int inputVal, int quantity, int yearToDate)
        {
            return new GammaCalculator(inputVal, quantity, yearToDate).Compute();
        }
    }
}
