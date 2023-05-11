using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public class SqlConnector : IDataConnection
    {
        private const string db = "Tournaments";
        public PersonModel CreatePerson(PersonModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                {
                    var p = new DynamicParameters();
                    p.Add("@FirstName", model.FirstName);
                    p.Add("@LastName", model.LastName);
                    p.Add("@EmailAddress", model.EmaiLAddress);
                    p.Add("@CellphoneNumber", model.CellPhoneNumber);
                    p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                    connection.Execute("dbo.spPeople_Insert", p, commandType: CommandType.StoredProcedure);

                    model.Id = p.Get<int>("@id");

                    return model;
                }
            }
        }

        public PrizeModel CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                {
                    var p = new DynamicParameters();
                    p.Add("@PlaceNumber", model.PlaceNumber);
                    p.Add("@PlaceName", model.PlaceName);
                    p.Add("@PrizeAmount", model.PrizeAmount);
                    p.Add("@PrizePercentage", model.PrizePercentage);
                    p.Add("@id", 0, dbType:DbType.Int32, direction: ParameterDirection.Output);

                    connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

                    model.Id = p.Get<int>("@id");

                    return model;
                }
            }
        }

        public TeamModel CreateTeam(TeamModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                {
                    var p = new DynamicParameters();
                    p.Add("@TeamName", model.TeamName);
                    p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                    connection.Execute("dbo.spTeam_Insert", p, commandType: CommandType.StoredProcedure);

                    model.Id = p.Get<int>("@id");

                    foreach (PersonModel tm in model.TeamMembers)
                    {
                        p = new DynamicParameters();
                        p.Add("@TeamId", model.Id);
                        p.Add("@PersonId", tm.Id);


                        connection.Execute("dbo.spTeamMembers_Insert", p, commandType: CommandType.StoredProcedure);
                    }

                    return model;
                }
            }
        }

        public TournamentModel CreateTournmanet(TournamentModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                {
                    SaveTournament(model, connection);

                    SaveTournamentPrizes(model, connection);

                    SaveTournamentEntries(model, connection);

                    SaveTournamentRounds(model, connection);

                    return model;
                }
            }
        }

        private void SaveTournament(TournamentModel model, IDbConnection connection)
        {
            var p = new DynamicParameters();
            p.Add("@TournamentName", model.TournamentName);
            p.Add("@EntryFee", model.EntreeFee);
            p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.spTournaments_Insert", p, commandType: CommandType.StoredProcedure);

            model.Id = p.Get<int>("@id");
        }

        private void SaveTournamentPrizes(TournamentModel model, IDbConnection connection)
        {
            foreach (PrizeModel pz in model.Prizes)
            {
                var p = new DynamicParameters();
                p.Add("@TournamentId", model.Id);
                p.Add("@PrizeId", pz.Id);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);


                connection.Execute("dbo.spTournamentPrizes_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }

        private void SaveTournamentEntries(TournamentModel model, IDbConnection connection)
        {
            foreach (TeamModel tm in model.EnteredTeams)
            {
                var p = new DynamicParameters();
                p.Add("@TournamentId", model.Id);
                p.Add("@TeamId", tm.Id);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTournamentEntries_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }

        private void SaveTournamentRounds(IDbConnection connection, TournamentModel model)
        {

        }
        public List<PersonModel> GetPerson_All()
        {
            List<PersonModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<PersonModel>("dbo.spPeople_GetAll").ToList();
            }


            return output;
        }

        public List<TeamModel> GetTeam_All()
        {
            List<TeamModel> output;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = connection.Query<TeamModel>("dbo.spTeam_GetAll").ToList();

                foreach (TeamModel tm in output) 
                {
                    var p = new DynamicParameters();
                    p.Add("@TeamID", tm.Id);
                    tm.TeamMembers = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam", p, commandType: CommandType.StoredProcedure).ToList();
                }
            }

            return output;
        }
    }
}
