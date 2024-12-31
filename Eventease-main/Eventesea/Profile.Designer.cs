namespace Eventesea
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.eventName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eventVenue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeStart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeEnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.textBox8);
            this.panel4.Controls.Add(this.textBox7);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.textBox6);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.textBox5);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.textBox4);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.listView1);
            this.panel4.Controls.Add(this.textBox3);
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.listView2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(615, 450);
            this.panel4.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Profile";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
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
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.eventName,
            this.eventVenue,
            this.timeStart,
            this.timeEnd});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(12, 11);
            this.listView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(591, 428);
            this.listView2.TabIndex = 6;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(31, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Username";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 253);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 22);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(43, 305);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 22);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(43, 360);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(151, 22);
            this.textBox3.TabIndex = 14;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(221, 58);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(357, 333);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Venue";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Time Start";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Time End";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(227, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Edit Profile";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(229, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Name";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(279, 99);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(274, 22);
            this.textBox4.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(229, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Username";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(305, 132);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(248, 22);
            this.textBox5.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(229, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Email";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(276, 162);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(277, 22);
            this.textBox6.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(478, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(228, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Change Password";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(229, 249);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "Password";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(229, 300);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "Confirm Password";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(243, 270);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(310, 22);
            this.textBox7.TabIndex = 27;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(243, 324);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(310, 22);
            this.textBox8.TabIndex = 28;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(478, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(380, 402);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 23);
            this.button3.TabIndex = 30;
            this.button3.Text = "Switch Account";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gray;
            this.button4.Location = new System.Drawing.Point(503, 402);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 31;
            this.button4.Text = "Log Out";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 450);
            this.Controls.Add(this.panel4);
            this.Name = "Form1";
            this.Text = "Profile";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader eventName;
        private System.Windows.Forms.ColumnHeader eventVenue;
        private System.Windows.Forms.ColumnHeader timeStart;
        private System.Windows.Forms.ColumnHeader timeEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
    }
}