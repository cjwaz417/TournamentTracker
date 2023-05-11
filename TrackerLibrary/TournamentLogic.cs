using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public static class TournamentLogic
    {
        public static void CreateRounds(TournamentModel model)
        {
            List<TeamModel> radomizedTeams = RadomizeTeamOrder(model.EnteredTeams);

            int rounds = FindNumberOfRounds(radomizedTeams.Count);

            int byes = NumberOfByes(rounds, radomizedTeams.Count);

            model.Rounds.Add(CreeateFirstRound(byes, radomizedTeams));

            CreateOtherRounds(model, rounds);
        }

        private static void CreateOtherRounds(TournamentModel model, int rounds)
        {
            int round = 2;
            List<MatchupModel> previousRound = model.Rounds[0];
            List<MatchupModel> currRound = new List<MatchupModel>();
            MatchupModel currMatchup = new MatchupModel();

            while (round <= rounds)
            {
                foreach (MatchupModel matchup in previousRound)
                {
                    currMatchup.Entry.Add(new MatchupEntryModel() { ParentMatchup = matchup });

                    if (currMatchup.Entry.Count > 1)
                    {
                        currMatchup.MatchUpRound = round;
                        currRound.Add(currMatchup);
                        currMatchup = new MatchupModel();
                    }
                }

                model.Rounds.Add(currRound);
                previousRound = currRound;
                currRound = new List<MatchupModel>();
                round += 1;
            }
        }

        private static List<MatchupModel> CreeateFirstRound(int byes, List<TeamModel> teams)
        {
            List<MatchupModel> output = new List<MatchupModel>();
            MatchupModel curr = new MatchupModel();

            foreach (TeamModel team in teams) 
            {
                curr.Entry.Add(new MatchupEntryModel { TeamsCompeting = team });

                if (byes > 0 || curr.Entry.Count > 1)
                {
                    curr.MatchUpRound = 1;
                    output.Add(curr);
                    curr = new MatchupModel();

                    if (byes > 0) 
                    {
                        byes -= 1;
                    }
                }
            }

            return output;
        }

        private static int NumberOfByes(int rounds, int numberOfTeams) 
        {
            int output = 0;
            int totalTeams = 1;

            for (int i = 1; i < rounds; i++)
            {
                totalTeams *= 2;
            }

            output = totalTeams - numberOfTeams;

            return output;
        }

        private static int FindNumberOfRounds(int TeamCount)
        {
            int output = 1;
            int val = 2;

            while (val < TeamCount)
            {
                output += 1;
                val *= 2;
            }
            return output;
        }

        private static List<TeamModel> RadomizeTeamOrder(List<TeamModel> teams) 
        {
            
            return teams.OrderBy(x => Guid.NewGuid()).ToList();
        }
    }
}
