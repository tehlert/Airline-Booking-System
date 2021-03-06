using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Air3550
{
    public partial class BoardingPassPopUpForm : Form
    {
        public BoardingPassPopUpForm()
        {
            InitializeComponent();
        }

        //Function to set the values of the UI
        public void setUIValues(string firstFlightNumber, string firstFlightDate, string firstFlightOriginCode, string firstFlightArrivalCode, 
            string firstFlightDepartTime, string firstFlightArrivalTime, string secondFlightNumber, string secondFlightDate, string secondFlightOriginCode, string secondFlightArrivalCode,
            string secondFlightDepartTime, string secondFlightArrivalTime, string firstName, string lastName, string customerID, bool roundTrip)
        {
            if (roundTrip)
            {
                //make labels visible and set them
                secondFlightNumberLabel.Visible = true;
                secondFlightNumberDateLabel.Visible = true;
                secondDepartLabel.Visible = true;
                secondArrivalLabel.Visible = true;
                secondDepartTimeLabel.Visible = true;
                secondArrivalTimeLabel.Visible = true;
                //set values
                secondFlightNumberLabel.Text = secondFlightNumber;
                secondFlightNumberDateLabel.Text = secondFlightDate;
                secondDepartLabel.Text = secondFlightOriginCode;
                secondArrivalLabel.Text = secondFlightArrivalCode;
                secondDepartTimeLabel.Text = secondFlightDepartTime;
                secondArrivalTimeLabel.Text = secondFlightArrivalTime;
                firstFlightNumberLabel.Text = firstFlightNumber;
                firstFlightDateLabel.Text = firstFlightDate;
                firstDepartLabel.Text = firstFlightOriginCode;
                firstArrivalLabel.Text = firstFlightArrivalCode;
                firstDepartTimeLabel.Text = firstFlightDepartTime;
                firstArrivalTimeLabel.Text = firstFlightArrivalTime;
            }
            else 
            {
                firstFlightNumberLabel.Text = firstFlightNumber;
                firstFlightDateLabel.Text = firstFlightDate;
                firstDepartLabel.Text = firstFlightOriginCode;
                firstArrivalLabel.Text = firstFlightArrivalCode;
                firstDepartTimeLabel.Text = firstFlightDepartTime;
                firstArrivalTimeLabel.Text = firstFlightArrivalTime;
            }
            firstNameLabel.Text = firstName;
            lastNameLabel.Text = lastName;
            accountNumberLabel.Text = customerID;
        }
        //Close form
        private void exitPassButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Autogenerated, do nothing
        private void BoardingPassPopUpForm_Load(object sender, EventArgs e)
        {

        }
    }
}
