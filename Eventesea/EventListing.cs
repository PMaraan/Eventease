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
    public partial class EventListing : Form
    {
        public EventListing()
        {
            InitializeComponent();
        }

        private void btnEventListing_Click(object sender, EventArgs e)
        {
            //debounce if the button clicked corresponds to the current page
            if (this.Text == "Event Listing") return;
            //open Event Listings page
            EventListing eventListing = new EventListing();
            eventListing.Show();
            this.Hide();
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            //debounce if the button clicked corresponds to the current page
            if (this.Text == "Calendar") return;
            //open Calendar page
            Calendar calendar = new Calendar();
            calendar.Show();
            this.Hide();
        }

        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            //debounce if the button clicked corresponds to the current page
            if (this.Text == "Analysis") return;
            //open Event Listings page
            Analysis analysis = new Analysis();
            analysis.Show();
            this.Hide();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            //debounce if the button clicked corresponds to the current page
            if (this.Text == "ManageEvent") return;
            //open Event Listings page
            ManageEvent manageEvent = new ManageEvent();
            manageEvent.Show();
            this.Hide();
        }
    }
}
