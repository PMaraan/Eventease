using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventesea
{
    public partial class ManageEvent : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\\Users\\admin\\source\\repos\\Eventease-main\\Eventesea\\EventEaseDB.mdb");
        OleDbDataAdapter da = new OleDbDataAdapter();
        OleDbCommand cmd = new OleDbCommand();

        public ManageEvent()
        {
            InitializeComponent();
            int currentUserID = UserSession.UserID;
            string currentUserName = UserSession.UserName;
            string currentUserFN = UserSession.UserFN;
            string currentUserLN = UserSession.UserLN;
            string currentUserEmail = UserSession.UserEmail;
            string currentUserPass = UserSession.UserPass;

            int eventSesID = EventSession.EventID;
            string eventSesName = EventSession.EventName;
            DateTime eventSesDate = EventSession.EventDate;
            DateTime eventSesStart = EventSession.EventStart;
            DateTime eventSesEnd = EventSession.EventEnd;
            string eventSesTicket = EventSession.EventTicket;

            con.Open();
            string searchEvent = $"SELECT* FROM Event_Database where Event_ID = {eventSesID}";
            cmd = new OleDbCommand(searchEvent, con);

            con.Close();
            txtEventName.Text = eventSesName;
            txtNumOfTickets.Text = eventSesTicket;
            timeStart.Value = eventSesStart;
            timeEnd.Value = eventSesEnd;
            
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
            if (this.Text == "ManageEvent") return;
            //open Event Listings page
            ManageEvent manageEvent = new ManageEvent();
            manageEvent.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //prompt the user to confirm action
            MessageBox.Show("Do you want to add entry to database?");
            //insert into database upon confirmation
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //prompt the user to confirm action
            MessageBox.Show("Do you want to delete entry in database? This action cannot be undone.");
            //insert into database upon confirmation
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //check for empty fields
            if (txtEventName.Text == string.Empty || txtVenue.Text == string.Empty || txtAddress.Text == string.Empty || txtHost.Text == string.Empty)
            {
                lblEmptyFieldsWarning.Visible = true;
            }
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

            //update the database

        }

    }
}
