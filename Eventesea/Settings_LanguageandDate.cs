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
    public partial class Settings_LanguageandDate : Form
    {
        public Settings_LanguageandDate()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Settings_DesignTheme settings = new Settings_DesignTheme();
            settings.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Settings_LanguageandDate settings = new Settings_LanguageandDate();
            settings.Show();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Settings_CalendarPreferences settings = new Settings_CalendarPreferences();
            settings.Show();
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Settings_DataExport settings = new Settings_DataExport();
            settings.Show();
            this.Close();
        }
    }
}
