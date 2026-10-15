using System;

namespace DPM235505_NLThanhDat_TH5_P57_FormTemplateMethod.Before
{
    public class Tea
    {
        public void PrepareRecipe()
        {
            Console.WriteLine("1. Đun nước");
            Console.WriteLine("2. Ngâm trà");
            Console.WriteLine("3. Rót ra cốc");
            Console.WriteLine("4. Thêm chanh"); // Các bước bị lặp lại ở class Coffee
        }
    }

    public class Coffee
    {
        public void PrepareRecipe()
        {
            Console.WriteLine("1. Đun nước");
            Console.WriteLine("2. Pha cà phê");
            Console.WriteLine("3. Rót ra cốc");
            Console.WriteLine("4. Thêm đường sữa");
        }
    }
}