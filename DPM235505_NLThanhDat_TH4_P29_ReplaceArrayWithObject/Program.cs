using System;
using DPM235505_NLThanhDat_TH4_P29_ReplaceArrayWithObject.After;
using DPM235505_NLThanhDat_TH4_P29_ReplaceArrayWithObject.Real;

namespace DPM235505_NLThanhDat_TH4_P29_ReplaceArrayWithObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- AFTER ---");
            TournamentRefactored tour = new TournamentRefactored();
            tour.ShowTeamInfo(new TeamPerformance { Name = "Arsenal", Wins = 20 });

            Console.WriteLine("\n--- REAL ---");
            QuanLyNhanSu ql = new QuanLyNhanSu();
            HoSoNhanVien nv = new HoSoNhanVien { HoTen = "Nguyễn Lê Thành Đạt", ChucVu = "Software Engineer", Luong = 25000000 };
            ql.InHoSo(nv);

            Console.ReadLine();
        }
    }
}