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
    public partial class CreateEvent : Form
    {
        OleDbConnection con = new OleDbConnection(Global.dbConnectionString);
        OleDbDataAdapter da = new OleDbDataAdapter();
        OleDbCommand cmd = new OleDbCommand();
        public CreateEvent()
        {
            InitializeComponent();
            int currentUserID = UserSession.UserID;
            string currentUserName = UserSession.UserName;
            string currentUserFN = UserSession.UserFN;
            string currentUserLN = UserSession.UserLN;
            string currentUserEmail = UserSession.UserEmail;
            string currentUserPass = UserSession.UserPass;
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
            //check number of eventIDs in db
            //This code will iterate the event_ID per registration
            con.Open();
            int newEventID = 0;
            string searchLastEventID = "SELECT TOP 1 Event_ID FROM Event_Database ORDER BY Event_ID DESC";
            cmd = new OleDbCommand(searchLastEventID, con);
            using (OleDbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    newEventID = reader.GetInt32(0) + 1;
                }
            }
            con.Close();
            MessageBox.Show(newEventID.ToString());
            //check for empty fields
            if (txtEventName.Text == string.Empty || txtVenue.Text == string.Empty || txtAddress.Text == string.Empty || txtHost.Text == string.Empty)
            {
                lblEmptyFieldsWarning.Visible = true;
                return;
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

            //insert into the database if all fields are complete
            if (lblEmptyFieldsWarning.Visible == false && lblValidNumWarning.Visible == false)
            {
                con.Open();

                string timeStartFormatted = timeStart.Value.ToString("HH:mm");
                string timeEndFormatted = timeEnd.Value.ToString("HH:mm");
                string dateFormatted = dateTimePicker1.Value.ToString("MM/dd/yyyy");

                string addEvent = $"INSERT into Event_Database (Event_ID, User_ID, Event_Name, Event_Venue, Event_Address, Event_Host, Event_Date, Event_TimeStart, Event_TimeEnd, Event_Tickets)" +
                    $" VALUES ({newEventID}, {UserSession.UserID}, '{txtEventName.Text}', '{txtVenue.Text}', '{txtAddress.Text}', '{txtHost.Text}', #{dateFormatted}#, #{timeStartFormatted}#, #{timeEndFormatted}#, {txtNumOfTickets.Text})";
                cmd = new OleDbCommand(addEvent, con);
                cmd.ExecuteNonQuery();
                con.Close();

                txtEventName.Clear();
                txtVenue.Clear();
                txtAddress.Clear();
                txtHost.Clear();

                MessageBox.Show("Event created successfully!");
            }
            else
            {
                return;
            }
        }

        private void CreateEvent_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pbxLogo_Click(object sender, EventArgs e)
        {
            Index index = new Index();
            index.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 profile = new Form1();
            profile.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Settings_DesignTheme settings = new Settings_DesignTheme();
            settings.Show();
        }
    }
}
