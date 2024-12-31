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
        //private int getTicketID()
        //{
        //    int nextTicketID;
        //    con.Open();

        //    try
        //    {
        //        // Check for deleted ticket IDs
        //        string checkDeletedEventQuery = "SELECT TOP 1 Ticket_ID FROM Deleted_TicketID ORDER BY Ticket_ID ASC";
        //        cmd = new OleDbCommand(checkDeletedEventQuery, con);
        //        var result = cmd.ExecuteScalar();

        //        if (result != null)
        //        {
        //            // Use the recycled ID from Deleted_TicketID
        //            nextTicketID = Convert.ToInt32(result);

        //            // Delete the used ID from Deleted_TicketID
        //            string deleteDeletedEventQuery = $"DELETE FROM Deleted_TicketID WHERE Ticket_ID = {nextTicketID}";
        //            cmd = new OleDbCommand(deleteDeletedEventQuery, con);
        //            cmd.ExecuteNonQuery();
        //        }
        //        else
        //        {
        //            // No deleted IDs available, get the max Ticket_ID
        //            string getMaxEventIDQuery = "SELECT MAX(Ticket_ID) FROM TicketSales_Rec";
        //            cmd = new OleDbCommand(getMaxEventIDQuery, con);
        //            var maxID = cmd.ExecuteScalar();
        //            nextTicketID = (maxID != DBNull.Value) ? Convert.ToInt32(maxID) + 1 : 1;
        //        }
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //    TicketSession.TicketID = nextTicketID;
        //    MessageBox.Show(nextTicketID.ToString());
        //    return nextTicketID;
        //}

        private void btnYes_Click(object sender, EventArgs e)
        {

            // Check for existing attendee with the same email for the event
            con.Open();
            string checkDuplicate = $"SELECT COUNT(*) FROM Attendee_Database WHERE Attendee_Email = '{AttendeeSession.AttendeeEmail}' AND Event_ID = {EventSession.EventID}";
            cmd = new OleDbCommand(checkDuplicate, con);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            if (count > 0)
            {
                MessageBox.Show("This attendee is already registered for the event.");
                return;
            }

            // Get new Attendee_ID
            con.Open();
            string queryLastID = "SELECT MAX(Attendee_ID) FROM Attendee_Database";
            cmd = new OleDbCommand(queryLastID, con);
            var maxID = cmd.ExecuteScalar();
            int newAttendeeID = (maxID != DBNull.Value) ? Convert.ToInt32(maxID) + 1 : 1;
            con.Close();

            // Insert new attendee
            con.Open();
            string addAttendee = $"INSERT INTO Attendee_Database (Attendee_ID, Attendee_Name, Attendee_Email, Event_ID) VALUES " +
                $"({newAttendeeID}, '{AttendeeSession.AttendeeName}', '{AttendeeSession.AttendeeEmail}', {EventSession.EventID})";
            cmd = new OleDbCommand(addAttendee, con);
            cmd.ExecuteNonQuery();
            con.Close();

            // Reload the listview
            manageEvent.LoadAttendees();

            MessageBox.Show("Attendee added successfully!");
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            //return to manage events page
            this.Close();
        }
    }
}
