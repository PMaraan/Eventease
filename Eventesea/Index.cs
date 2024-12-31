using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventesea
{
    public partial class Index : Form
    {
        OleDbConnection con = new OleDbConnection(Global.dbConnectionString);
        OleDbDataAdapter da = new OleDbDataAdapter();
        OleDbCommand cmd = new OleDbCommand();
        public Index()
        {
            InitializeComponent();
            int currentUserID = UserSession.UserID;
            string currentUserName = UserSession.UserName;
            string currentUserFN = UserSession.UserFN;
            string currentUserLN = UserSession.UserLN;
            string currentUserEmail = UserSession.UserEmail;
            string currentUserPass = UserSession.UserPass;
            USERNAME.Text = $"Welcome, {UserSession.UserName}";

            con.Open();
            //display all created events in list
            string getEvent = $"SELECT* FROM Event_Database ORDER BY Event_Name ASC";
            da = new OleDbDataAdapter(getEvent, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            eventList.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                DateTime timeStart = DateTime.Parse(dr["Event_TimeStart"].ToString());
                DateTime timeEnd = DateTime.Parse(dr["Event_TimeEnd"].ToString());
                DateTime eventDate = DateTime.Parse(dr["Event_Date"].ToString());


                ListViewItem item = new ListViewItem(dr["Event_Name"].ToString());
                item.SubItems.Add(dr["Event_Venue"].ToString());
                item.SubItems.Add(dr["Event_Address"].ToString());
                item.SubItems.Add(dr["Event_Host"].ToString());
                item.SubItems.Add(timeStart.ToString("HH:mm"));
                item.SubItems.Add(timeEnd.ToString("HH:mm"));
                item.SubItems.Add(dr["Event_ID"].ToString());
                item.SubItems.Add(eventDate.ToString("MM/dd/yyyy"));
                item.SubItems.Add(dr["Event_Tickets"].ToString());
                item.SubItems.Add(dr["User_ID"].ToString());
                eventList.Items.Add(item);
            }
            con.Close();

            

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void eventList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //display all attendees on selected list
            con.Open();
            if (eventList.SelectedItems.Count > 0)
            {
                //get EventID of selected event in the event list
                ListViewItem selectedItem = eventList.SelectedItems[0];
                if (int.TryParse(selectedItem.SubItems[6].Text, out int eventID))
                {
                    EventSession.EventID = eventID;
                }
                //display host label
                lblHostName.Text = selectedItem.SubItems[3].Text;
                //display attendees of the selected event
                string getAttendee = $"SELECT Attendee_Name FROM Attendee_Database WHERE Event_ID = {eventID} ORDER BY Attendee_Name ASC";
                da = new OleDbDataAdapter(getAttendee, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                attendeeList.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(dr["Attendee_Name"].ToString());
                    attendeeList.Items.Add(item);
                }

                //get max tickets
                if (int.TryParse(selectedItem.SubItems[8].Text, out int ticketMax))
                {
                    TicketSession.TicketMax = ticketMax;
                }

                // Get tickets sold
                string getSoldTickets = $"SELECT COUNT(*) FROM Attendee_Database WHERE Event_ID = {eventID}";
                using (OleDbCommand cmd = new OleDbCommand(getSoldTickets, con))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int ticketsSold))
                    {
                        TicketSession.TicketSold = ticketsSold;

                        // Calculate unsold tickets
                        int ticketsUnsold = ticketMax - ticketsSold;

                        lblTicketSales.Text = $"{ticketsSold}";
                        lblTicketUnsold.Text = $"{ticketsUnsold}";
                    }
                }
                con.Close();

            }
            con.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 profile = new Form1();
            profile.Show();
            this.Hide();
        }

        private void pbxLogo_Click(object sender, EventArgs e)
        {
            Index index = new Index();
            index.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Settings_DesignTheme settings = new Settings_DesignTheme();
            settings.Show();

        }
    }
}
