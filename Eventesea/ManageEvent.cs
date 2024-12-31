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
        OleDbConnection con = new OleDbConnection(Global.dbConnectionString);
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
            string eventSesDate = EventSession.EventDate;
            string eventSesStart = EventSession.EventStart;
            string eventSesEnd = EventSession.EventEnd;
            string eventSesTicket = EventSession.EventTicket;

            DateTime formattedDate, formattedTimeStart, formattedTimeEnd;
            if (DateTime.TryParse(eventSesDate, out formattedDate) &&
                DateTime.TryParse(eventSesStart, out formattedTimeStart) &&
                DateTime.TryParse(eventSesEnd, out formattedTimeEnd))
            {
                dateTimePicker1.Value = formattedDate;
                timeStart.Value = formattedTimeStart;
                timeEnd.Value = formattedTimeEnd;
            }
            con.Open();
            string searchEvent = $"SELECT Event_Venue, Event_Address, Event_Host FROM Event_Database where Event_ID = {eventSesID}";
            cmd = new OleDbCommand(searchEvent, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    txtVenue.Text = dr["Event_Venue"].ToString();
                    txtAddress.Text = dr["Event_Address"].ToString();
                    txtHost.Text = dr["Event_Host"].ToString();
                }
            }
            txtEventName.Text = eventSesName;
            txtNumOfTickets.Text = eventSesTicket;
            con.Close();

            con.Open();
            string searchAttendee = $"SELECT* FROM Attendee_Database WHERE Event_ID = {eventSesID}";
            da = new OleDbDataAdapter(searchAttendee, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            listView1.Items.Clear();

            foreach (DataRow read in dt.Rows)
            {
                ListViewItem item = new ListViewItem(read["Attendee_Name"].ToString());
                item.SubItems.Add(read["Attendee_Email"].ToString());
                item.SubItems.Add(read["Event_ID"].ToString());
                item.SubItems.Add(read["Attendee_ID"].ToString());
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
            if (this.Text == "ManageEvent") return;
            //open Event Listings page
            ManageEvent manageEvent = new ManageEvent();
            manageEvent.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //prompt the user to confirm action
            MsgBoxAddAttendee msgadd = new MsgBoxAddAttendee(this);
            AttendeeSession.AttendeeName = txtAttendeeName.Text;
            AttendeeSession.AttendeeEmail = txtAttendeeEmail.Text;
            msgadd.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                if (int.TryParse(selectedItem.SubItems[3].Text, out int id))
                {
                    AttendeeSession.AttendeeID = id;
                }

                //prompt the user to confirm action
                MsgBoxRemoveAttendee msgremove = new MsgBoxRemoveAttendee(this);
                msgremove.Show();
            }
            else
            {
                MessageBox.Show("Select an attendee to delete.");
            }
        }

        public void LoadAttendees()
        {
            //used to refresh the attendees listview
            con.Open();
            string searchAttendee = $"SELECT * FROM Attendee_Database WHERE Event_ID = {EventSession.EventID}";
            da = new OleDbDataAdapter(searchAttendee, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            listView1.Items.Clear();

            foreach (DataRow read in dt.Rows)
            {
                ListViewItem item = new ListViewItem(read["Attendee_Name"].ToString());
                item.SubItems.Add(read["Attendee_Email"].ToString());
                item.SubItems.Add(read["Event_ID"].ToString());
                item.SubItems.Add(read["Attendee_ID"].ToString());
                listView1.Items.Add(item);
            }
            con.Close();
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
            if (lblEmptyFieldsWarning.Visible == false && lblValidNumWarning.Visible == false)
            {
                con.Open();

                string timeStartFormatted = timeStart.Value.ToString("HH:mm");
                string timeEndFormatted = timeEnd.Value.ToString("HH:mm");
                string dateFormatted = dateTimePicker1.Value.ToString("MM/dd/yyyy");

                string updateEvent = $"UPDATE Event_Database SET User_ID = {UserSession.UserID}, Event_Name = '{txtEventName.Text}', " +
                    $"Event_Venue = '{txtVenue.Text}', Event_Address = '{txtAddress.Text}', Event_Host = '{txtHost.Text}', Event_Date = #{dateFormatted}#, " +
                    $"Event_TimeStart = #{timeStartFormatted}#, Event_TimeEnd = #{timeEndFormatted}#, Event_Tickets = {txtNumOfTickets.Text} WHERE Event_ID = {EventSession.EventID}";
                cmd = new OleDbCommand(updateEvent, con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Event updated successfully!");
            }
            else
            {
                return;
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
