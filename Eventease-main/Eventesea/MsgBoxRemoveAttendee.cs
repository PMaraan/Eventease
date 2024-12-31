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
    public partial class MsgBoxRemoveAttendee : Form
    {
        OleDbConnection con = new OleDbConnection(Global.dbConnectionString);
        OleDbDataAdapter da = new OleDbDataAdapter();
        OleDbCommand cmd = new OleDbCommand();
        private ManageEvent manageEvent;
        public MsgBoxRemoveAttendee(ManageEvent manageEvent)
        {
            InitializeComponent();
            this.manageEvent = manageEvent;

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
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            try
            {
                //delete attendee and calculate tickets
                using (OleDbConnection con = new OleDbConnection(Global.dbConnectionString))
                {
                    con.Open();
                    string deleteAttend = $"DELETE FROM Attendee_Database WHERE Attendee_ID = {AttendeeSession.AttendeeID}";
                    using (OleDbCommand cmd = new OleDbCommand(deleteAttend, con))
                    {
                        cmd.ExecuteNonQuery();
                    }

                }
        
                //refresh attendee list
                manageEvent.LoadAttendees();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while removing the attendee: {ex.Message}");
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


////This code will iterate the user_ID per registration
//con.Open();
//int newAttendeeID = 1;
//string queryLastID = "SELECT MAX(Attendee_ID) FROM Attendee_Database";
//cmd = new OleDbCommand(queryLastID, con);
//var maxID = cmd.ExecuteScalar();
//newAttendeeID = (maxID != DBNull.Value) ? Convert.ToInt32(maxID) + 1 : 1;
//con.Close();

////insert into database
//con.Open();
//string addAttendee = $"INSERT INTO Attendee_Database (Attendee_ID, Attendee_Name, Attendee_Email, Event_ID) VALUES " +
//    $"({newAttendeeID}, '{AttendeeSession.AttendeeName}', '{AttendeeSession.AttendeeEmail}', {EventSession.EventID})";
//cmd = new OleDbCommand(addAttendee, con);
//cmd.ExecuteNonQuery();
//con.Close();

////insert into tickets database for iteratioon
//con.Open();
//int newTicketID = getTicketID();
//string addTicket = $"INSERT INTO TicketSales_Rec (Ticket_ID, Attendee_ID, Event_ID) VALUES " +
//    $"({newTicketID}, {newAttendeeID}, {EventSession.EventID})";
//cmd = new OleDbCommand(addTicket, con);
//cmd.ExecuteNonQuery();
//TicketSession.TicketID = newTicketID;
//con.Close();

////reload the listview
//manageEvent.LoadAttendees();
//this.Close();