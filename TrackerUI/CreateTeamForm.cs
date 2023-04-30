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
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        public CreateTeamForm()
        {
            InitializeComponent();
            //CreateSampleData();
            WireUpLists();
        }

        private void WireUpLists()
        {
            SelectTeamMemverDropDown.DataSource = null;

            SelectTeamMemverDropDown.DataSource = availableTeamMembers;
            SelectTeamMemverDropDown.DisplayMember = "FullName";

            TeamMembersListBox.DataSource = null;

            TeamMembersListBox.DataSource = selectedTeamMembers;
            TeamMembersListBox.DisplayMember = "FullName";
        }



        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Chirs", LastName = "Waz" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Yo", LastName = "Momma" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Stinky", LastName = "PooPoo" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Ben", LastName = "Dover" });
        }

        private void addTeamLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddTeamButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)SelectTeamMemverDropDown.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                WireUpLists();
            }

        }

        private void AddTeamDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void teamOneScoreText_TextChanged(object sender, EventArgs e)
        {

        }

        private void FirstNameLabel_Click(object sender, EventArgs e)
        {
        }

        private void AddNewMemberGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void CreateMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();
                p.FirstName = FirstNameText.Text;
                p.LastName = LastNameText.Text;
                p.EmaiLAddress = EmailText.Text;
                p.CellPhoneNumber = CellText.Text;

                p = GlobalConfig.Connection.CreatePerson(p);

                selectedTeamMembers.Add(p);

                WireUpLists();

                FirstNameText.Text = "";
                LastNameText.Text = "";
                EmailText.Text = "";
                CellText.Text = "";

            }
            else
            {
                MessageBox.Show("Fill out yo form boi smfh dumb ahh can't fill out a simple form!");
            }
        }

        private bool ValidateForm()
        {
            if (FirstNameText.Text.Length == 0)
            {
                return false;
            }

            if (LastNameText.Text.Length == 0)
            { return false; }

            if (EmailText.Text.Length == 0)
            { return false; }

            if (CellText.Text.Length == 0)
            {
                return false;
            }

            return true;

        }

        private void TeamMembersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RenoveSelectedMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)TeamMembersListBox.SelectedItem;


            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                WireUpLists();

            }

        }

        private void CreateTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();

            t.TeamName = TeamNameValue.Text;
            t.TeamMembers = selectedTeamMembers;

            t = GlobalConfig.Connection.CreateTeam(t);
        }
    }
}
