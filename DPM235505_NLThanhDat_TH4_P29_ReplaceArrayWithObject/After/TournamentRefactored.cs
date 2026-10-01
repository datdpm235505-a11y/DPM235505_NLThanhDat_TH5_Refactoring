using System;

namespace DPM235505_NLThanhDat_TH4_P29_ReplaceArrayWithObject.After
{
    public class TournamentRefactored
    {
        public void ShowTeamInfo(TeamPerformance team)
        {
            Console.WriteLine($"Đội {team.Name} có {team.Wins} trận thắng.");
        }
    }
}