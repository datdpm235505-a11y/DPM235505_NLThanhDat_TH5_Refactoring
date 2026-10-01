using System;
using DPM235505_NLThanhDat_TH4_P16_PreserveWholeObject.After;
using DPM235505_NLThanhDat_TH4_P16_PreserveWholeObject.Real;

namespace DPM235505_NLThanhDat_TH4_P16_PreserveWholeObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            RoomTempRefactored room = new RoomTempRefactored();
            HeatingPlanRefactored plan = new HeatingPlanRefactored();
            plan.CheckTemperature(room);

            Console.WriteLine("\n--- REAL ---");
            ThongTinLienHe tt = new ThongTinLienHe { Email = "dat@gmail.com", SoDienThoai = "0909123456" };
            HeThongThongBao heThong = new HeThongThongBao();
            heThong.GuiThongBao("Thành Đạt", tt);

            Console.ReadLine();
        }
    }
}