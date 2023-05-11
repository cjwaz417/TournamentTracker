using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelper;

namespace TrackerLibrary
{
    public class TextConnector : IDataConnection
    {

        private const string PrizesFile = "PrizeModels.csv";
        private const string PeopleFile = "PersonModels.csv";
        private const string TeamFile = "TeamModels.csv";

        public PersonModel CreatePerson(PersonModel model)
        {
            List<PersonModel> person = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModel();

            int currentId = 1;

            if (person.Count > 0) 
            {
                currentId = person.OrderByDescending(x => x.Id).First().Id + 1;
            
            
            }

            model.Id = currentId;
            person.Add(model);

            person.SaveToPersonFile(PeopleFile);

            return model;
        }

        public PrizeModel CreatePrize(PrizeModel model)
        {
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModel();

            int currentId = 1;

            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
             }
            model.Id = currentId;
            
            prizes.Add(model);

            prizes.SaveToPrizeFile(PrizesFile);

            return model;

        }

        public TeamModel CreateTeam(TeamModel model)
        {
            List<TeamModel> teams = TeamFile.FullFilePath().LoadFile().ConvertToTeamModel(PeopleFile);

            int currentId = 1;

            if (teams.Count > 0)
            {
                currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            teams.Add(model);

            //teams.SaveToTeamModel(TeamFile);

            return model;
        }

        public List<PersonModel> GetPerson_All()
        {
            return PeopleFile.FullFilePath().LoadFile().ConvertToPersonModel();


        }

        public List<TeamModel> GetTeam_All()
        {
            throw new NotImplementedException();
        }
    }
}
