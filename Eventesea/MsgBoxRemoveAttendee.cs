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
            //cancels operation and returns to the manage event page
            this.Close();
        }
    }
}
