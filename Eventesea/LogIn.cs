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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            //query the database
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //redirect to sign up page
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }
    }
}
