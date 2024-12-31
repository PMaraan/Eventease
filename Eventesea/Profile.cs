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
    public partial class Form1 : Form
    {
        OleDbConnection con = new OleDbConnection(Global.dbConnectionString);
        OleDbDataAdapter da = new OleDbDataAdapter();
        OleDbCommand cmd = new OleDbCommand();

        public Form1()
        {
            InitializeComponent();
            int currentUserID = UserSession.UserID;
            string currentUserName = UserSession.UserName;
            string currentUserFN = UserSession.UserFN;
            string currentUserLN = UserSession.UserLN;
            string currentUserEmail = UserSession.UserEmail;
            string currentUserPass = UserSession.UserPass;

            con.Open();
            // Query to fetch user details
            string getUser = $"SELECT User_FN, User_LN, User_name, User_Email FROM User_Accounts WHERE User_ID = {currentUserID}";
            cmd = new OleDbCommand(getUser, con);

            // Execute the queryz
            OleDbDataReader reader = cmd.ExecuteReader();

            // If data exists, assign it to the textboxes
            if (reader.Read())
            {
                txtFNInfo.Text = reader["User_FN"].ToString();
                txtLNInfo.Text = reader["User_LN"].ToString();
                txtUsernameInfo.Text = reader["User_Name"].ToString();
                txtEmailInfo.Text = reader["User_Email"].ToString();
            }

            reader.Close();
            con.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Index index = new Index();
            index.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MsgBoxLogoutConfirm logoutConfirm = new MsgBoxLogoutConfirm();
            logoutConfirm.Show();
        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtInputFN.Text) &&
                !string.IsNullOrEmpty(txtInputLN.Text) &&
                !string.IsNullOrEmpty(txtInputName.Text) &&
                !string.IsNullOrEmpty(txtInputEmail.Text))
            {
                con.Open();

                string updateUser = $"UPDATE User_Accounts SET " +
                    $"User_FN = '{txtInputFN.Text}', " +
                    $"User_LN = '{txtInputLN.Text}', " +
                    $"User_name = '{txtInputName.Text}', " +
                    $"User_Email = '{txtInputEmail.Text}' " +
                    $"WHERE User_ID = {UserSession.UserID}";

                cmd = new OleDbCommand(updateUser, con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("User information updated successfully!");
            }
            else
            {
                MessageBox.Show("Please fill in all fields before updating.");
            }
        }

        private void btnSavePass_Click(object sender, EventArgs e)
        {
            
            if(txtInputPass.Text == string.Empty || txtInputConfPass.Text == string.Empty)
            {
                lblEmptyFieldWarning.Visible = true;
                return;
            }

            if(txtInputPass.Text == txtInputConfPass.Text)
            {
                MsgBoxChangePassConfirm msgpass = new MsgBoxChangePassConfirm(this);
                UserSession.UserPass = txtInputConfPass.Text;
                msgpass.Show();
            }
            else
            {
                lblPasswordWarning.Visible = true;
                txtInputPass.Text = string.Empty;
                txtInputConfPass.Text = string.Empty;
                return;
            }

            //prompt the user to confirm action

        }
    }
}
