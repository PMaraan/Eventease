namespace Eventesea
{
    partial class ManageEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageEvent));
            this.panel1 = new System.Windows.Forms.Panel();
            this.timeEnd = new System.Windows.Forms.DateTimePicker();
            this.timeStart = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblEmptyFieldsWarning = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtVenue = new System.Windows.Forms.TextBox();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtAttendeeEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.attendeeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.attendeeEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eventID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.attendID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAttendeeName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblValidNumWarning = new System.Windows.Forms.Label();
            this.txtNumOfTickets = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEventListing = new System.Windows.Forms.Button();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.btnAnalysis = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.timeEnd);
            this.panel1.Controls.Add(this.timeStart);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lblEmptyFieldsWarning);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.txtHost);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtVenue);
            this.panel1.Controls.Add(this.txtEventName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(22, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 612);
            this.panel1.TabIndex = 5;
            // 
            // timeEnd
            // 
            this.timeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeEnd.Location = new System.Drawing.Point(36, 367);
            this.timeEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timeEnd.Name = "timeEnd";
            this.timeEnd.Size = new System.Drawing.Size(282, 22);
            this.timeEnd.TabIndex = 20;
            // 
            // timeStart
            // 
            this.timeStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeStart.Location = new System.Drawing.Point(36, 306);
            this.timeStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timeStart.Name = "timeStart";
            this.timeStart.Size = new System.Drawing.Size(282, 22);
            this.timeStart.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 404);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "Event Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(36, 425);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(282, 22);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 349);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Time End:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Time Start:";
            // 
            // lblEmptyFieldsWarning
            // 
            this.lblEmptyFieldsWarning.AutoSize = true;
            this.lblEmptyFieldsWarning.ForeColor = System.Drawing.Color.Red;
            this.lblEmptyFieldsWarning.Location = new System.Drawing.Point(32, 474);
            this.lblEmptyFieldsWarning.Name = "lblEmptyFieldsWarning";
            this.lblEmptyFieldsWarning.Size = new System.Drawing.Size(184, 16);
            this.lblEmptyFieldsWarning.TabIndex = 11;
            this.lblEmptyFieldsWarning.Text = "*Make sure all fields are filled.";
            this.lblEmptyFieldsWarning.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(114, 535);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(131, 38);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(36, 232);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(282, 22);
            this.txtHost.TabIndex = 8;
            this.txtHost.Text = "Enter Event Host:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(36, 180);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(282, 22);
            this.txtAddress.TabIndex = 7;
            this.txtAddress.Text = "Enter Event address:";
            // 
            // txtVenue
            // 
            this.txtVenue.Location = new System.Drawing.Point(36, 124);
            this.txtVenue.Name = "txtVenue";
            this.txtVenue.Size = new System.Drawing.Size(282, 22);
            this.txtVenue.TabIndex = 6;
            this.txtVenue.Text = "Enter Event Venue:";
            // 
            // txtEventName
            // 
            this.txtEventName.Location = new System.Drawing.Point(36, 72);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(282, 22);
            this.txtEventName.TabIndex = 5;
            this.txtEventName.Text = "Enter Event Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Event Host:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Event Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Event Venue:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Event Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Event";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.txtAttendeeEmail);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.txtAttendeeName);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(463, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(641, 405);
            this.panel2.TabIndex = 6;
            // 
            // txtAttendeeEmail
            // 
            this.txtAttendeeEmail.Location = new System.Drawing.Point(86, 143);
            this.txtAttendeeEmail.Name = "txtAttendeeEmail";
            this.txtAttendeeEmail.Size = new System.Drawing.Size(423, 22);
            this.txtAttendeeEmail.TabIndex = 8;
            this.txtAttendeeEmail.Text = "Attendee Email:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(72, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 16);
            this.label13.TabIndex = 7;
            this.label13.Text = "Attendee Email:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.attendeeName,
            this.attendeeEmail,
            this.eventID,
            this.attendID});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(17, 232);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(611, 157);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // attendeeName
            // 
            this.attendeeName.Text = "Name";
            this.attendeeName.Width = 100;
            // 
            // attendeeEmail
            // 
            this.attendeeEmail.Text = "Email";
            this.attendeeEmail.Width = 100;
            // 
            // eventID
            // 
            this.eventID.Text = "EventID";
            this.eventID.Width = 20;
            // 
            // attendID
            // 
            this.attendID.Text = "ID";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(327, 200);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(144, 27);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(135, 200);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 27);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAttendeeName
            // 
            this.txtAttendeeName.Location = new System.Drawing.Point(86, 93);
            this.txtAttendeeName.Name = "txtAttendeeName";
            this.txtAttendeeName.Size = new System.Drawing.Size(423, 22);
            this.txtAttendeeName.TabIndex = 2;
            this.txtAttendeeName.Text = "Attendee Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Attendee Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Register Attendee";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.lblValidNumWarning);
            this.panel3.Controls.Add(this.txtNumOfTickets);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(463, 520);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(641, 178);
            this.panel3.TabIndex = 7;
            // 
            // lblValidNumWarning
            // 
            this.lblValidNumWarning.AutoSize = true;
            this.lblValidNumWarning.ForeColor = System.Drawing.Color.Red;
            this.lblValidNumWarning.Location = new System.Drawing.Point(83, 101);
            this.lblValidNumWarning.Name = "lblValidNumWarning";
            this.lblValidNumWarning.Size = new System.Drawing.Size(182, 16);
            this.lblValidNumWarning.TabIndex = 12;
            this.lblValidNumWarning.Text = "*Please enter a valid number.";
            this.lblValidNumWarning.Visible = false;
            // 
            // txtNumOfTickets
            // 
            this.txtNumOfTickets.Location = new System.Drawing.Point(86, 76);
            this.txtNumOfTickets.Name = "txtNumOfTickets";
            this.txtNumOfTickets.Size = new System.Drawing.Size(423, 22);
            this.txtNumOfTickets.TabIndex = 2;
            this.txtNumOfTickets.Text = "Enter No. of Tickets:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Register No. of Tickets";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(210, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Register No. of Tickets";
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
            this.tableLayoutPanel1.TabIndex = 8;
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
            this.btnManage.Text = "Manage Event";
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
            // ManageEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1191, 710);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ManageEvent";
            this.Text = "ManageEvent";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtVenue;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAttendeeName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtNumOfTickets;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnEventListing;
        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.Button btnAnalysis;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblEmptyFieldsWarning;
        private System.Windows.Forms.Label lblValidNumWarning;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker timeEnd;
        private System.Windows.Forms.DateTimePicker timeStart;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader attendeeName;
        private System.Windows.Forms.ColumnHeader attendeeEmail;
        private System.Windows.Forms.TextBox txtAttendeeEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ColumnHeader eventID;
        private System.Windows.Forms.ColumnHeader attendID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}