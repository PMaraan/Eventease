﻿using System;
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
    public partial class ManageEvent : Form
    {
        public ManageEvent()
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //prompt the user to confirm action
            MessageBox.Show("Do you want to add entry to database?");
            //insert into database upon confirmation
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //prompt the user to confirm action
            MessageBox.Show("Do you want to delete entry in database? This action cannot be undone.");
            //insert into database upon confirmation
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //check for empty fields
            if (txtEventName.Text == string.Empty || txtVenue.Text == string.Empty || txtAddress.Text == string.Empty || txtHost.Text == string.Empty)
            {
                lblEmptyFieldsWarning.Visible = true;
            }
            //update the database
        }

        private void btnRegisterTickets_Click(object sender, EventArgs e)
        {
            //check if input is an integer
            if (!int.TryParse(txtNumOfTickets.Text, out int num))
            {
                lblValidNumWarning.Visible = true;
                return;
            }
            //check if value is a positive value
            else if (num <= 0)
            {
                lblValidNumWarning.Visible = true;
                return;
            }
            lblValidNumWarning.Visible = false;
            //insert into database
        }
    }
}