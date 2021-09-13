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
    //basic manifest ticket form which displays first and last name of customer
    public partial class ManifestTicketForm : Form
    {
        public ManifestTicketForm()
        {
            InitializeComponent();
        }

        //do nothing here
        private void lastNameLabel_Click(object sender, EventArgs e)
        {

        }

        //set applicable values
        public void setUIValues(string firstName, string lastName)
        {
            firstNameLabel.Text = firstName;
            lastNameLabel.Text = lastName;
        }

        private void ManifestTicketForm_Load(object sender, EventArgs e)
        {

        }
    }
}
