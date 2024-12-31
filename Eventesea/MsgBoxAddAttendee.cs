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
    public partial class MsgBoxAddAttendee : Form
    {
        OleDbConnection con = new OleDbConnection(Global.dbConnectionString);
        OleDbDataAdapter da = new OleDbDataAdapter();
        OleDbCommand cmd = new OleDbCommand();
        private ManageEvent manageEvent;
        public MsgBoxAddAttendee(ManageEvent manageEvent)
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
            con.Open();

            //This code will iterate the user_ID per registration
            int newAttendanceID = 1;
            string searchLastAttendanceID = "SELECT TOP 1 Attendee_ID FROM Attendee_Database ORDER BY Attendee_ID DESC";
            cmd = new OleDbCommand(searchLastAttendanceID, con);
            using (OleDbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    newAttendanceID = reader.GetInt32(0) + 1;
                }
            }
            con.Close();

            //insert into database
            con.Open();
            string addAttendee = $"INSERT INTO Attendee_Database (Attendee_ID, Attendee_Name, Attendee_Email, Event_ID) VALUES " +
                $"({newAttendanceID}, '{AttendeeSession.AttendeeName}', '{AttendeeSession.AttendeeEmail}', {EventSession.EventID})";
            cmd = new OleDbCommand(addAttendee, con);
            cmd.ExecuteNonQuery();
            con.Close();

            //reload the listview
            manageEvent.LoadAttendees();
            
            this.Close();

        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            //return to manage events page
            this.Close();
        }
    }
}
