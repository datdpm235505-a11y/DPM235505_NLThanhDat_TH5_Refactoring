using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235505_NLThanhDat_TH4_P08_ReplaceMethodWithMethodObject.After
{
    public class GammaCalculator
    {
        private int _inputVal, _quantity, _yearToDate, _importantValue1, _importantValue2, _importantValue3;
        public GammaCalculator(int inputVal, int quantity, int yearToDate)
        {
            _inputVal = inputVal; _quantity = quantity; _yearToDate = yearToDate;
        }
        public int Compute()
        {
            _importantValue1 = (_inputVal * _quantity) + 10; // Delta
            _importantValue2 = (_inputVal * _yearToDate) + 100;
            if ((_yearToDate - _importantValue1) > 100) _importantValue2 -= 20;
            _importantValue3 = _importantValue2 * 7;
            return _importantValue3 - 2 * _importantValue1;
        }
    }
}
