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
using static Eventesea.Analysis;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Eventesea
{
    public partial class Analysis : Form
    {
        OleDbConnection con = new OleDbConnection(Global.dbConnectionString);
        OleDbDataAdapter da = new OleDbDataAdapter();
        OleDbCommand cmd = new OleDbCommand();
        public Analysis()
        {
            InitializeComponent();
            PopulateComboBox();
            int currentUserID = UserSession.UserID;
            string currentUserName = UserSession.UserName;
            string currentUserFN = UserSession.UserFN;
            string currentUserLN = UserSession.UserLN;
            string currentUserEmail = UserSession.UserEmail;
            string currentUserPass = UserSession.UserPass;
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
            if (this.Text == "CreateEvent") return;
            //open Event Listings page
            CreateEvent createEvent = new CreateEvent();
            createEvent.Show();
            this.Hide();
        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }
            public int MaxTickets { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void PopulateComboBox()
        {
            con.Open();
            string getEvents = $"SELECT* FROM Event_Database WHERE User_ID = {UserSession.UserID}";
            cmd = new OleDbCommand(getEvents, con);
            OleDbDataReader reader = cmd.ExecuteReader();
            ComboboxItem comboBox = new ComboboxItem();

            while (reader.Read())
            {
                int maxTickets = 0;
                if (int.TryParse(reader["Event_Tickets"].ToString(), out maxTickets))
                {
                    comboBox1.Items.Add(new ComboboxItem
                    {
                        Text = reader["Event_Name"].ToString(),
                        Value = Convert.ToInt32(reader["Event_ID"]),
                        MaxTickets = maxTickets,
                    });
                    
                }
            }

            reader.Close();
            con.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is ComboboxItem selectedEvent)
            {
                try
                {
                    con.Open();

                    // Fetch the number of attendees
                    string getAttendees = $"SELECT COUNT(*) FROM Attendee_Database WHERE Event_ID = {selectedEvent.Value}";
                    cmd = new OleDbCommand(getAttendees, con);
                    object attendeeResult = cmd.ExecuteScalar();
                    int ticketsSold = attendeeResult != null && int.TryParse(attendeeResult.ToString(), out int count) ? count : 0;

                    int maxTickets = selectedEvent.MaxTickets;

                    // Calculate unsold tickets
                    int ticketsUnsold = maxTickets - ticketsSold;

                    // Display results
                    lblTicketSold.Text = ticketsSold.ToString();
                    lblTicketUnsold.Text = ticketsUnsold.ToString();
                    lblAttenNum.Text = attendeeResult.ToString();

                    UpdateChart(ticketsSold, ticketsUnsold, maxTickets);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error fetching event data: {ex.Message}");
                }
                finally
                {
                    con.Close();
                }

            }
        }

        private void UpdateChart(int ticketsSold, int ticketsUnsold, int maxTickets)
        {
            // Clear any existing data in the chart
            chart1.Series.Clear();

            // Create a new series for the chart
            var series = new System.Windows.Forms.DataVisualization.Charting.Series("EventData")
            {
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar,
                BorderWidth = 2,
                Color = System.Drawing.Color.Blue
            };

            series.Points.AddXY("Sold Tickets", ticketsSold);
            series.Points.AddXY("Unsold Tickets", ticketsUnsold);
            series.Points.AddXY("Total Attendees", ticketsSold); 

            // Add the series to the chart
            chart1.Series.Add(series);

            int maxValue = Math.Max(ticketsSold, Math.Max(ticketsUnsold, maxTickets));
            chart1.ChartAreas[0].AxisY.Maximum = maxValue;
            int interval = (maxValue / 10) == 0 ? 1 : (maxValue / 10);

            chart1.ChartAreas[0].AxisY.Interval = interval;

            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;

            chart1.Legends.Clear();
        }
        private void pbxLogo_Click(object sender, EventArgs e)
        {
            Index index = new Index();
            index.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 profile = new Form1();
            profile.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Settings_DesignTheme settings = new Settings_DesignTheme();
            settings.Show();
        }
    }
}
