using System;
using DPM235505_NLThanhDat_TH5_P33_ExtractSuperclass.After;
using DPM235505_NLThanhDat_TH5_P33_ExtractSuperclass.Real;

namespace DPM235505_NLThanhDat_TH5_P33_ExtractSuperclass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            Party emp = new EmployeeRefactored { Name = "John", MonthlySalary = 3000 };
            Console.WriteLine($"Chi phí hàng năm của {emp.Name}: {emp.GetAnnualCost()} USD");

            Console.WriteLine("\n--- REAL ---");
            DoiTuongNhanSu nv = new NhanVien { MaSo = "NV001", HoTen = "Thành Đạt", Email = "dat@uag.edu.vn", ChucVu = "Kỹ sư phần mềm" };
            DoiTuongNhanSu dt = new DoiTac { MaSo = "DT002", HoTen = "Nguyễn Văn A", Email = "a@partner.com", TenCongTy = "Viettel" };

            nv.InRole();
            dt.InRole();

            Console.ReadLine();
        }
    }
}