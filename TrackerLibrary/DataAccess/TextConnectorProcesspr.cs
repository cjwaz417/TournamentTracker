using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.DataAccess.TextHelper
{
    public static class TextConnectorProcesspr
    {
        public static string FullFilePath(this string fileName)
        {
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }

        public static List<string> LoadFile(this string file)
            {
                if (!File.Exists(file)) 
                {
                    return new List<string>();
                }

                return File.ReadLines(file).ToList();
            }

        public static List<PrizeModel> ConvertToPrizeModel (this List<string> lines)
            {
                List<PrizeModel> output = new List<PrizeModel>();
                foreach (string line in lines)
                {
                    string[] cols = line.Split(',');
                    PrizeModel p = new PrizeModel();
                    p.Id = int.Parse(cols[0]);
                    p.PlaceNumber = int.Parse(cols[1]);
                    p.PlaceName = cols[2];
                    p.PrizeAmount = decimal.Parse(cols[3]);
                    p.PrizePercentage = double.Parse(cols[4]);
                    output.Add(p);
                }
                return output;
            }

        public static List<PersonModel> ConvertToPersonModel (this List<string> lines) 
        {
            List<PersonModel> output = new List<PersonModel> ();

            foreach (string line in lines) 
            {
                string[] cols = line.Split(',');
                PersonModel p = new PersonModel();
                p.Id= int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.EmaiLAddress = cols[3];
                p.CellPhoneNumber = cols[4];
                output.Add(p);
            
            }
            return output;
        
        }

        public static List<TeamModel> ConvertToTeamModel (this List<string> lines, string peopleFileName) 
        {

            List<TeamModel> output = new List<TeamModel>();
            List<PersonModel> person = peopleFileName.FullFilePath().LoadFile().ConvertToPersonModel();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                TeamModel t = new TeamModel();
                t.Id = int.Parse(cols[0]);
                t.TeamName = cols[1];

                string[] personIds = cols[2].Split('|');

                foreach (string id in personIds)
                {
                    t.TeamMembers.Add(person.Where(x => x.Id == int.Parse(id)).First());
                }
            }

            return output;
        
        }

        public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (PrizeModel p in models)
            {
                lines.Add($"{p.Id},{p.PlaceNumber},{p.PlaceName},{p.PrizeAmount},{p.PrizePercentage}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToPersonFile(this List<PersonModel> models, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (PersonModel p in models)
            {
                lines.Add($"{p.Id},{p.FirstName},{p.LastName},{p.EmaiLAddress},{p.CellPhoneNumber}");
            }
            
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToTeamFile(this List<TeamModel> models, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (TeamModel tm in models)
            {
                lines.Add($"{tm.Id},{tm.TeamName},{ConvertPeopleListToStribg(tm.TeamMembers)}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines );
        }

        private static string ConvertPeopleListToStribg(List<PersonModel> people)
        {
            string output = "";

            if (people.Count == 0) 
            { 
                return "";
            }

            foreach (PersonModel p in people)
            {
                output += $"{p.Id}|";
            
            }
            output = output.Substring(0, output.Length - 1);
            return output;
        }

    }
}
