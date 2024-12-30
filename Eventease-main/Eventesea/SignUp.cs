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
    public partial class SignUp : Form
    {
        //OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\\Users\\admin\\source\\repos\\Eventease-main\\Eventesea\\EventEaseDB.mdb");
        //OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Properties.Resources.EventEaseDB");
        OleDbConnection con = new OleDbConnection(Globals.dbConnectionString);
        OleDbDataAdapter da = new OleDbDataAdapter();
        OleDbCommand cmd = new OleDbCommand();
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //check for empty fields
            if (txtFirst.Text == string.Empty || txtLast.Text == string.Empty || txtUsername.Text == string.Empty || txtEmail.Text == string.Empty || txtPass.Text == string.Empty || txtConfPass.Text == string.Empty)
            {
                lblEmptyFieldWarning.Visible = true;
                return;
            }

            if (txtPass.Text == txtConfPass.Text)
            {
                try
                {
                    con.Open();

                    //This code will iterate the user_ID per registration
                    int newUserID = 1;
                    string searchLastUserID = "SELECT TOP 1 User_ID FROM User_Accounts ORDER BY User_ID DESC";
                    cmd = new OleDbCommand(searchLastUserID, con);
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            newUserID = reader.GetInt32(0) + 1;
                        }
                    }
                    con.Close();

                    con.Open();
                    //insert into database
                    string register = $"INSERT into User_Accounts (User_ID, User_name, User_FN, User_LN, User_Email, User_Password) VALUES ({newUserID}, '{txtUsername.Text}', '{txtFirst.Text}', '{txtLast.Text}', '{txtEmail.Text}', '{txtPass.Text}')";
                    cmd = new OleDbCommand(register, con);
                    cmd.ExecuteNonQuery();

                    txtFirst.Clear();
                    txtLast.Clear();
                    txtUsername.Clear();
                    txtEmail.Clear();
                    txtPass.Clear();
                    txtConfPass.Clear();
                    con.Close();

                    MessageBox.Show($"Account has been registered! + {newUserID}");
                    //LogIn logIn = new LogIn();
                    //logIn.Show();
                    //this.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message );
                }
                finally
                {
                    //con.Close();
                    lblPasswordWarning.Visible = false;
                }
            }
            //if passwords do not match
            else 
            { 
                lblPasswordWarning.Visible = true;
                txtPass.Text = string.Empty;
                txtConfPass.Text = string.Empty;
                txtPass.Focus();
                return;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPass.PasswordChar = '\0';
                txtConfPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
                txtConfPass.PasswordChar = '*';
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }
    }
}
