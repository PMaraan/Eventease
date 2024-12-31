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
    public partial class MsgBoxChangePassConfirm : Form
    {
        OleDbConnection con = new OleDbConnection(Global.dbConnectionString);
        OleDbDataAdapter da = new OleDbDataAdapter();
        OleDbCommand cmd = new OleDbCommand();
        private Form1 profile;
        public MsgBoxChangePassConfirm(Form1 profile)
        {
            InitializeComponent();
            this.profile = profile;
            int currentUserID = UserSession.UserID;
            string newUserPass = UserSession.UserPass;

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            con.Open();

            string updatePass = $"UPDATE User_Accounts SET User_Password = '{UserSession.UserPass}' WHERE User_ID = {UserSession.UserID}";
            cmd = new OleDbCommand(updatePass, con);
            cmd.ExecuteNonQuery();
            con.Close();
            this.Close();

            MessageBox.Show("Password changed successfully!");
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
