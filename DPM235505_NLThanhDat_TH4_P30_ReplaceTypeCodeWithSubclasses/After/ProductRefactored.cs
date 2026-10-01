using System;

namespace DPM235505_NLThanhDat_TH4_P30_ReplaceTypeCodeWithSubclasses.After
{
    public abstract class ProductRefactored
    {
        public abstract void PrintCategory();
    }

    public class ElectronicsProduct : ProductRefactored
    {
        public override void PrintCategory() => Console.WriteLine("Sản phẩm: Đồ điện tử");
    }

    public class FoodProduct : ProductRefactored
    {
        public override void PrintCategory() => Console.WriteLine("Sản phẩm: Thực phẩm");
    }
}