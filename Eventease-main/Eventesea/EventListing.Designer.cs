namespace Eventesea
{
    partial class EventListing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventListing));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.eventName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eventDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeStart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeEnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ticketNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eventID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEventListing = new System.Windows.Forms.Button();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.btnAnalysis = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(502, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "List of Events";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Location = new System.Drawing.Point(31, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1130, 292);
            this.panel1.TabIndex = 5;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.eventName,
            this.eventDate,
            this.timeStart,
            this.timeEnd,
            this.ticketNum,
            this.eventID});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(16, 21);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1096, 250);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // eventName
            // 
            this.eventName.Text = "Event Name";
            this.eventName.Width = 200;
            // 
            // eventDate
            // 
            this.eventDate.Text = "Event Date";
            this.eventDate.Width = 70;
            // 
            // timeStart
            // 
            this.timeStart.Text = "Time Start";
            this.timeStart.Width = 70;
            // 
            // timeEnd
            // 
            this.timeEnd.Text = "Time End";
            this.timeEnd.Width = 70;
            // 
            // ticketNum
            // 
            this.ticketNum.Text = "Total Tickets";
            this.ticketNum.Width = 100;
            // 
            // eventID
            // 
            this.eventID.Text = "ID";
            this.eventID.Width = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightGray;
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.btnEventListing, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCalendar, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAnalysis, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnManage, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbxLogo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 7, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1191, 69);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // btnEventListing
            // 
            this.btnEventListing.BackColor = System.Drawing.Color.LightGray;
            this.btnEventListing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEventListing.FlatAppearance.BorderSize = 0;
            this.btnEventListing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventListing.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventListing.Location = new System.Drawing.Point(205, 3);
            this.btnEventListing.Name = "btnEventListing";
            this.btnEventListing.Size = new System.Drawing.Size(196, 63);
            this.btnEventListing.TabIndex = 0;
            this.btnEventListing.Text = "Event Listing";
            this.btnEventListing.UseVisualStyleBackColor = false;
            this.btnEventListing.Click += new System.EventHandler(this.btnEventListing_Click);
            // 
            // btnCalendar
            // 
            this.btnCalendar.BackColor = System.Drawing.Color.LightGray;
            this.btnCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCalendar.FlatAppearance.BorderSize = 0;
            this.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendar.Location = new System.Drawing.Point(407, 3);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(196, 63);
            this.btnCalendar.TabIndex = 1;
            this.btnCalendar.Text = "Calendar";
            this.btnCalendar.UseVisualStyleBackColor = false;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAnalysis.FlatAppearance.BorderSize = 0;
            this.btnAnalysis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalysis.Location = new System.Drawing.Point(609, 3);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(196, 63);
            this.btnAnalysis.TabIndex = 2;
            this.btnAnalysis.Text = "Analysis";
            this.btnAnalysis.UseVisualStyleBackColor = true;
            this.btnAnalysis.Click += new System.EventHandler(this.btnAnalysis_Click);
            // 
            // btnManage
            // 
            this.btnManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnManage.FlatAppearance.BorderSize = 0;
            this.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManage.Location = new System.Drawing.Point(811, 3);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(196, 63);
            this.btnManage.TabIndex = 3;
            this.btnManage.Text = "Create Event";
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbxLogo.InitialImage")));
            this.pbxLogo.Location = new System.Drawing.Point(3, 3);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(129, 62);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 7;
            this.pbxLogo.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(960, 446);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Manage Selected Event";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1013, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1072, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1131, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // EventListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 710);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "EventListing";
            this.Text = "Event Listing";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnEventListing;
        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.Button btnAnalysis;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader eventName;
        private System.Windows.Forms.ColumnHeader eventDate;
        private System.Windows.Forms.ColumnHeader timeStart;
        private System.Windows.Forms.ColumnHeader timeEnd;
        private System.Windows.Forms.ColumnHeader ticketNum;
        private System.Windows.Forms.ColumnHeader eventID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}