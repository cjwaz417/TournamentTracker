using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        public List<MatchupEntryModel> Entry { get; set; } = new List<MatchupEntryModel>();
        public TeamModel Winner { get; set; }
        public int MatchUpRound { get; set; }


    }
}
