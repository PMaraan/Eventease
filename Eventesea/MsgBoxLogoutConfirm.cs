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
    public partial class MsgBoxLogoutConfirm : Form
    {
        public MsgBoxLogoutConfirm()
        {
            InitializeComponent();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            UserSession.UserID = 0;
            UserSession.UserName = string.Empty;
            UserSession.UserEmail = string.Empty;
            UserSession.UserPass = string.Empty;
            UserSession.UserFN = string.Empty;
            UserSession.UserLN = string.Empty;

            EventSession.EventID = 0;
            EventSession.EventTicket = string.Empty;
            EventSession.EventStart = string.Empty;
            EventSession.EventEnd = string.Empty;
            EventSession.EventDate = string.Empty;
            EventSession.EventName = string.Empty;
            
            AttendeeSession.AttendeeID = 0;
            AttendeeSession.AttendeeName = string.Empty;
            AttendeeSession.AttendeeEmail = string.Empty;

            TicketSession.TicketMax = 0;
            TicketSession.TicketSold = 0;
            TicketSession.TicketUnsold = 0;

            MessageBox.Show("Successfully Logged Out!");

            Application.Restart();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
