using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventesea
{
    public partial class CreateEvent : Form
    {
        public CreateEvent()
        {
            InitializeComponent();
        }

        private void btnEventListing_Click(object sender, EventArgs e)
        {
            //debounce if the button clicked corresponds to the current page
            if (this.Text == "Event Listing") return;
            //open Event Listings page
            EventListing eventListing = new EventListing();
            eventListing.Show();
            this.Hide();
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            //debounce if the button clicked corresponds to the current page
            if (this.Text == "Calendar") return;
            //open Calendar page
            Calendar calendar = new Calendar();
            calendar.Show();
            this.Hide();
        }

        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            //debounce if the button clicked corresponds to the current page
            if (this.Text == "Analysis") return;
            //open Event Listings page
            Analysis analysis = new Analysis();
            analysis.Show();
            this.Hide();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            //debounce if the button clicked corresponds to the current page
            if (this.Text == "CreateEvent") return;
            //open Event Listings page
            CreateEvent createEvent = new CreateEvent();
            createEvent.Show();
            this.Hide();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //check for empty fields
            if(txtEventName.Text == string.Empty || txtVenue.Text == string.Empty || txtAddress.Text == string.Empty || txtHost.Text == string.Empty)
            {
                lblEmptyFieldsWarning.Visible = true;
            }
            //insert into the database
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //insert into database
        }

        private void btnRegisterTickets_Click(object sender, EventArgs e)
        {
            //check if input is an integer
            if (!int.TryParse(txtNumOfTickets.Text, out int num))
            {
                lblValidNumWarning.Visible = true;
                return;
            }
            //check if value is a positive value
            else if (num <= 0)
            {
                lblValidNumWarning.Visible = true;
                return;
            }
            lblValidNumWarning.Visible = false;
            //insert into database
        }
    }
}
