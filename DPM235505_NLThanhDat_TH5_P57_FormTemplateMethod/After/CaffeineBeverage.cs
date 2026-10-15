using System;

namespace DPM235505_NLThanhDat_TH5_P57_FormTemplateMethod.After
{
    // Lớp cha chứa Khuôn mẫu thuật toán
    public abstract class CaffeineBeverage
    {
        // Template Method (Khuôn mẫu cố định)
        public void PrepareRecipe()
        {
            BoilWater();
            Brew(); // Bước trừu tượng để class con tự làm
            PourInCup();
            AddCondiments(); // Bước trừu tượng
        }

        private void BoilWater() => Console.WriteLine("- Đun nước");
        private void PourInCup() => Console.WriteLine("- Rót ra cốc");

        protected abstract void Brew();
        protected abstract void AddCondiments();
    }

    public class TeaRefactored : CaffeineBeverage
    {
        protected override void Brew() => Console.WriteLine("- Ngâm trà");
        protected override void AddCondiments() => Console.WriteLine("- Thêm chanh");
    }

    public class CoffeeRefactored : CaffeineBeverage
    {
        protected override void Brew() => Console.WriteLine("- Pha chế cà phê");
        protected override void AddCondiments() => Console.WriteLine("- Thêm đường và sữa");
    }
}