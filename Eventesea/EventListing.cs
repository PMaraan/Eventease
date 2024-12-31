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
    public partial class EventListing : Form
    {
        OleDbConnection con = new OleDbConnection(Global.dbConnectionString);
        OleDbDataAdapter da = new OleDbDataAdapter();
        OleDbCommand cmd = new OleDbCommand();

        public EventListing()
        {
            InitializeComponent();
            int currentUserID = UserSession.UserID;
            string currentUserName = UserSession.UserName;
            string currentUserFN = UserSession.UserFN;
            string currentUserLN = UserSession.UserLN;
            string currentUserEmail = UserSession.UserEmail;
            string currentUserPass = UserSession.UserPass;

            con.Open();
            string viewEvents = $"SELECT* FROM Event_Database where User_ID = {UserSession.UserID}";
            da = new OleDbDataAdapter(viewEvents, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            listView1.Items.Clear();

            foreach(DataRow dr in dt.Rows)
            {
                //format the date and time
                DateTime eventDate = DateTime.Parse(dr["Event_Date"].ToString());
                DateTime timeStart = DateTime.Parse(dr["Event_TimeStart"].ToString());
                DateTime timeEnd = DateTime.Parse(dr["Event_TimeEnd"].ToString());

                ListViewItem item = new ListViewItem(dr["Event_Name"].ToString());
                item.SubItems.Add(eventDate.ToString("MM/dd/yyyy"));                
                item.SubItems.Add(timeStart.ToString("HH:mm"));            
                item.SubItems.Add(timeEnd.ToString("HH:mm"));
                item.SubItems.Add(dr["Event_Tickets"].ToString());
                item.SubItems.Add(dr["Event_ID"].ToString());
                listView1.Items.Add(item);
            }
            con.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            //creates an event session so the selected event is also applied in the manage event page
            if(listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];

                EventSession.EventName = selectedItem.SubItems[0].Text;
                EventSession.EventTicket = selectedItem.SubItems[4].Text;
                
                if(int.TryParse(selectedItem.SubItems[5].Text, out int eventID) && 
                    DateTime.TryParse(selectedItem.SubItems[1].Text, out DateTime eventDate) && 
                    DateTime.TryParse(selectedItem.SubItems[2].Text, out DateTime eventStart) && 
                    DateTime.TryParse(selectedItem.SubItems[3].Text, out DateTime eventEnd))
                {
                    EventSession.EventID = eventID;
                    EventSession.EventDate = eventDate.ToString();
                    EventSession.EventStart = eventStart.ToString();
                    EventSession.EventEnd = eventEnd.ToString();
                }

                ManageEvent manage = new ManageEvent();
                manage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Select an event to manage!");
            }
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
