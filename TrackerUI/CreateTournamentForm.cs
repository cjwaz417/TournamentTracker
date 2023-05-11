using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class CreateTournamentForm : Form, IPrizeRequester, ITeamRequester
    {

        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();
        List<int> testnumber = new List<int>();
        public CreateTournamentForm()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists()
        {
            AddTeamDropDown.DataSource = null;
            AddTeamDropDown.DataSource = availableTeams;
            AddTeamDropDown.DisplayMember = "TeamName";

            TournamentPlayersListBox.DataSource = null;
            TournamentPlayersListBox.DataSource = selectedTeams;
            TournamentPlayersListBox.DisplayMember = "TeamName";

            PrizesListBox.DataSource = null;
            PrizesListBox.DataSource = selectedPrizes;
            PrizesListBox.DisplayMember = "PlaceName";

            numBox.DataSource = null;
            numBox.DataSource = testnumber;

            numBox.DisplayMember = testnumber.ToString();




        }

        private void AddTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel tm = (TeamModel)AddTeamDropDown.SelectedItem;

            if (tm != null)
            {
                availableTeams.Remove(tm);
                selectedTeams.Add(tm);

                WireUpLists();
            }
        }

        private void DeleteSelectedPlayersButton_Click(object sender, EventArgs e)
        {
            TeamModel tm = (TeamModel)TournamentPlayersListBox.SelectedItem;

            if (tm != null)
            {
                availableTeams.Add(tm);
                selectedTeams.Remove(tm);

                WireUpLists();
            }
        }

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show();
        }

        public void PrizeComplete(PrizeModel model)
        {
            selectedPrizes.Add(model);
            WireUpLists();
        }


        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireUpLists();
        }

        public void TestComm(int num)
        {
            testnumber.Add(num);
            WireUpLists();
        }

        private void CreateNewTeamLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm frm = new CreateTeamForm(this);
            frm.Show();
        }

        private void DeleteSelectedPrizeButton_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)PrizesListBox.SelectedItem;

            if (p != null)
            {
                selectedPrizes.Remove(p);
                WireUpLists();
            }
        }

        private void CreateTournamentButton_Click(object sender, EventArgs e)
        {
            decimal fee = 0;

            bool feeAcceptable = decimal.TryParse(entryFeeText.Text, out fee);

            if (!feeAcceptable) 
            {
                MessageBox.Show("You need to enter a valid decimal bozo", "Invalid Fee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            TournamentModel tm = new TournamentModel();

            tm.TournamentName = TournamentNameValue.Text;
            tm.EntreeFee = fee;

            tm.Prizes = selectedPrizes;
            tm.EnteredTeams = selectedTeams;

            TournamentLogic.CreateRounds(tm);

            GlobalConfig.Connection.CreateTournmanet(tm);
        }
    }
}
