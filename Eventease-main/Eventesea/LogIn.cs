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
    public partial class LogIn : Form
    {
        //string conStr = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Properties.Resources.EventEaseDB;
        //OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\\Users\\admin\\source\\repos\\Eventease-main\\Eventesea\\EventEaseDB.mdb");
        //OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=|DataDirectory|\EventEaseDB.mdb");
        OleDbConnection con = new OleDbConnection(Globals.dbConnectionString);
        //OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=EventEaseDB");
        OleDbDataAdapter da = new OleDbDataAdapter();
        OleDbCommand cmd = new OleDbCommand();
        
        public LogIn()
        {
            InitializeComponent();
            //MessageBox.Show("DB path: " +  Properties.Resources.EventEaseDB);
            
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            //query the database
            con.Open();
            string login = $"SELECT* FROM User_Accounts WHERE User_Email= '{txtEmail.Text}' and User_Password='{txtPassword.Text}'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                //Get user infor and prepare session
                UserSession.UserID = dr.GetInt32(0);
                UserSession.UserName = dr.GetString(1);
                UserSession.UserFN = dr.GetString(2);
                UserSession.UserLN = dr.GetString(3);
                UserSession.UserEmail = dr.GetString(4);
                UserSession.UserPass = dr.GetString(5);

                //Load to index form
                Index index = new Index();
                index.Show();
                this.Hide();
                con.Close();
            }
            else 
            {
                MessageBox.Show("INvalid Email or Password, Try again.", "Invalid Credentials!", MessageBoxButtons.OK);
                txtEmail.Clear();
                txtPassword.Clear();
                txtEmail.Focus();
                con.Close();
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //redirect to sign up page
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
