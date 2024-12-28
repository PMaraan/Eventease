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
    public partial class SignUp : Form
    {
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
            //check if passwords match
            if (txtPass.Text != txtConfPass.Text)
            {
                lblPasswordWarning.Visible = true;
                return;
            }
            //insert into database
        }
    }
}
