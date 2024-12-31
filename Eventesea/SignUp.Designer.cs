namespace Eventesea
{
    partial class SignUp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPasswordWarning = new System.Windows.Forms.Label();
            this.lblEmptyFieldWarning = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtConfPass = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.lblPasswordWarning);
            this.panel1.Controls.Add(this.lblEmptyFieldWarning);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.txtConfPass);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.txtLast);
            this.panel1.Controls.Add(this.txtFirst);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(38, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 490);
            this.panel1.TabIndex = 0;
            // 
            // lblPasswordWarning
            // 
            this.lblPasswordWarning.AutoSize = true;
            this.lblPasswordWarning.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordWarning.Location = new System.Drawing.Point(38, 458);
            this.lblPasswordWarning.Name = "lblPasswordWarning";
            this.lblPasswordWarning.Size = new System.Drawing.Size(196, 20);
            this.lblPasswordWarning.TabIndex = 10;
            this.lblPasswordWarning.Text = "*Passwords doesn\'t match";
            this.lblPasswordWarning.Visible = false;
            // 
            // lblEmptyFieldWarning
            // 
            this.lblEmptyFieldWarning.AutoSize = true;
            this.lblEmptyFieldWarning.ForeColor = System.Drawing.Color.Red;
            this.lblEmptyFieldWarning.Location = new System.Drawing.Point(36, 422);
            this.lblEmptyFieldWarning.Name = "lblEmptyFieldWarning";
            this.lblEmptyFieldWarning.Size = new System.Drawing.Size(262, 20);
            this.lblEmptyFieldWarning.TabIndex = 9;
            this.lblEmptyFieldWarning.Text = "*Make sure ther are no empty fields.";
            this.lblEmptyFieldWarning.Visible = false;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Black;
            this.btnRegister.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegister.Location = new System.Drawing.Point(581, 371);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(195, 44);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtConfPass
            // 
            this.txtConfPass.Location = new System.Drawing.Point(29, 371);
            this.txtConfPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConfPass.Name = "txtConfPass";
            this.txtConfPass.PasswordChar = '*';
            this.txtConfPass.Size = new System.Drawing.Size(526, 26);
            this.txtConfPass.TabIndex = 7;
            this.txtConfPass.Text = "Confirm Password";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(35, 310);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(522, 26);
            this.txtPass.TabIndex = 6;
            this.txtPass.Text = "Password";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(36, 254);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(520, 26);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.Text = "E-Mail Address";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(39, 200);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(518, 26);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.Text = "Username";
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(288, 148);
            this.txtLast.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(260, 26);
            this.txtLast.TabIndex = 3;
            this.txtLast.Text = "Last Name";
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(42, 149);
            this.txtFirst.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(223, 26);
            this.txtFirst.TabIndex = 2;
            this.txtFirst.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fill in the form below to get instant access:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up Now";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(581, 312);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(148, 24);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Black;
            this.btnReturn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReturn.Location = new System.Drawing.Point(581, 423);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(195, 44);
            this.btnReturn.TabIndex = 12;
            this.btnReturn.Text = "Back";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtConfPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblEmptyFieldWarning;
        private System.Windows.Forms.Label lblPasswordWarning;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnReturn;
    }
}