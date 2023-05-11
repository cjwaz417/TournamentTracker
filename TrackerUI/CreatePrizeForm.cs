using Microsoft.VisualBasic;
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
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        IPrizeRequester callingform;


        public CreatePrizeForm(IPrizeRequester caller)
        {
            InitializeComponent();
            callingform = caller;
        }

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(PlaceNameValue.Text, PLaceNumberText.Text, PrizeAmountText.Text, PrizePercentageText.Text);
                int num = 69;
               GlobalConfig.Connection.CreatePrize(model);

                callingform.PrizeComplete(model);

                this.Close();
            }
            else
            {
                MessageBox.Show("This form is fucked uup brother. Fix it");
            }
            PlaceNameValue.Text = "";
            PLaceNumberText.Text = "";
            PrizeAmountText.Text = "0";
            PrizePercentageText.Text = "0";
        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(PLaceNumberText.Text, out placeNumber);

            if (!placeNumberValidNumber)
            {
                output = false;
            }

            if (placeNumber < 1)
            {
                output = false;
            }

            if (PlaceNameValue.Text.Length == 0)
            {
                output = false;
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(PrizeAmountText.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(PrizePercentageText.Text, out prizePercentage);

            if (!prizeAmountValid || !prizePercentageValid)
            {
                output = false;
            }

            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }

            if (prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }
            return output;
        }
    }
}
