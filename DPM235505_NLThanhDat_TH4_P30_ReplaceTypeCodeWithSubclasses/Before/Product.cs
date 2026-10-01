using System;

namespace DPM235505_NLThanhDat_TH4_P30_ReplaceTypeCodeWithSubclasses.Before
{
    public class Product
    {
        public const int ELECTRONICS = 0;
        public const int FOOD = 1;

        private int _type;

        public Product(int type)
        {
            _type = type;
        }

        public void PrintCategory()
        {
            if (_type == ELECTRONICS) Console.WriteLine("Sản phẩm: Đồ điện tử");
            else if (_type == FOOD) Console.WriteLine("Sản phẩm: Thực phẩm");
        }
    }
}