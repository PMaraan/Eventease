namespace Eventesea
{
    partial class Notifications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notifications));
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.eventName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eventVenue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeStart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeEnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.listView2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.lblTitle);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(633, 497);
            this.panel4.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(559, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.eventName,
            this.eventVenue,
            this.timeStart,
            this.timeEnd});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(12, 111);
            this.listView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(591, 328);
            this.listView2.TabIndex = 6;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // eventName
            // 
            this.eventName.Text = "Name";
            // 
            // eventVenue
            // 
            this.eventVenue.Text = "Venue";
            // 
            // timeStart
            // 
            this.timeStart.Text = "Time Start";
            // 
            // timeEnd
            // 
            this.timeEnd.Text = "Time End";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Unread";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "All";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(277, 49);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Notifications";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Notifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(615, 450);
            this.Controls.Add(this.panel4);
            this.Name = "Notifications";
            this.Text = "Notifications";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader eventName;
        private System.Windows.Forms.ColumnHeader eventVenue;
        private System.Windows.Forms.ColumnHeader timeStart;
        private System.Windows.Forms.ColumnHeader timeEnd;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}