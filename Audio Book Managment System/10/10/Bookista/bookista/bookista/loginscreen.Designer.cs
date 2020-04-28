namespace bookista
{
    partial class loginscreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginscreen));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.forgetpassword = new System.Windows.Forms.Label();
            this.rememberme = new System.Windows.Forms.Label();
            this.remembermecheckbox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.createyouraccount = new System.Windows.Forms.Label();
            this.donthaveanaccount = new System.Windows.Forms.Label();
            this.loginbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.forgetpassword);
            this.panel1.Controls.Add(this.rememberme);
            this.panel1.Controls.Add(this.remembermecheckbox);
            this.panel1.Controls.Add(this.createyouraccount);
            this.panel1.Controls.Add(this.donthaveanaccount);
            this.panel1.Controls.Add(this.loginbtn);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.username);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 596);
            this.panel1.TabIndex = 0;
            // 
            // forgetpassword
            // 
            this.forgetpassword.AutoSize = true;
            this.forgetpassword.BackColor = System.Drawing.Color.White;
            this.forgetpassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgetpassword.Font = new System.Drawing.Font("Myriad Pro", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgetpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.forgetpassword.Location = new System.Drawing.Point(343, 436);
            this.forgetpassword.Name = "forgetpassword";
            this.forgetpassword.Size = new System.Drawing.Size(150, 23);
            this.forgetpassword.TabIndex = 7;
            this.forgetpassword.Text = "Forgot password?";
            // 
            // rememberme
            // 
            this.rememberme.AutoSize = true;
            this.rememberme.BackColor = System.Drawing.Color.White;
            this.rememberme.Font = new System.Drawing.Font("Myriad Pro", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rememberme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.rememberme.Location = new System.Drawing.Point(74, 438);
            this.rememberme.Name = "rememberme";
            this.rememberme.Size = new System.Drawing.Size(128, 23);
            this.rememberme.TabIndex = 6;
            this.rememberme.Text = "Remember Me";
            // 
            // remembermecheckbox
            // 
            this.remembermecheckbox.BackColor = System.Drawing.Color.White;
            this.remembermecheckbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.remembermecheckbox.ChechedOffColor = System.Drawing.Color.White;
            this.remembermecheckbox.Checked = false;
            this.remembermecheckbox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(71)))), ((int)(((byte)(220)))));
            this.remembermecheckbox.ForeColor = System.Drawing.Color.White;
            this.remembermecheckbox.Location = new System.Drawing.Point(47, 438);
            this.remembermecheckbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.remembermecheckbox.Name = "remembermecheckbox";
            this.remembermecheckbox.Size = new System.Drawing.Size(20, 20);
            this.remembermecheckbox.TabIndex = 5;
            this.remembermecheckbox.Tag = "";
            // 
            // createyouraccount
            // 
            this.createyouraccount.AutoSize = true;
            this.createyouraccount.BackColor = System.Drawing.Color.White;
            this.createyouraccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createyouraccount.Font = new System.Drawing.Font("Myriad Pro", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createyouraccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(54)))), ((int)(((byte)(213)))));
            this.createyouraccount.Location = new System.Drawing.Point(245, 196);
            this.createyouraccount.Name = "createyouraccount";
            this.createyouraccount.Size = new System.Drawing.Size(169, 23);
            this.createyouraccount.TabIndex = 4;
            this.createyouraccount.Text = "Create your account";
            // 
            // donthaveanaccount
            // 
            this.donthaveanaccount.AutoSize = true;
            this.donthaveanaccount.BackColor = System.Drawing.Color.White;
            this.donthaveanaccount.Font = new System.Drawing.Font("Myriad Pro", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donthaveanaccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.donthaveanaccount.Location = new System.Drawing.Point(43, 196);
            this.donthaveanaccount.Name = "donthaveanaccount";
            this.donthaveanaccount.Size = new System.Drawing.Size(197, 23);
            this.donthaveanaccount.TabIndex = 3;
            this.donthaveanaccount.Text = "Don\'t have an account?";
            // 
            // loginbtn
            // 
            this.loginbtn.ActiveBorderThickness = 1;
            this.loginbtn.ActiveCornerRadius = 35;
            this.loginbtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(54)))), ((int)(((byte)(213)))));
            this.loginbtn.ActiveForecolor = System.Drawing.Color.White;
            this.loginbtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(54)))), ((int)(((byte)(213)))));
            this.loginbtn.BackColor = System.Drawing.SystemColors.Control;
            this.loginbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginbtn.BackgroundImage")));
            this.loginbtn.ButtonText = "LOGIN";
            this.loginbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginbtn.Font = new System.Drawing.Font("Source Sans Pro", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.loginbtn.IdleBorderThickness = 1;
            this.loginbtn.IdleCornerRadius = 35;
            this.loginbtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(71)))), ((int)(((byte)(220)))));
            this.loginbtn.IdleForecolor = System.Drawing.Color.White;
            this.loginbtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(71)))), ((int)(((byte)(220)))));
            this.loginbtn.Location = new System.Drawing.Point(320, 481);
            this.loginbtn.Margin = new System.Windows.Forms.Padding(6);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(153, 67);
            this.loginbtn.TabIndex = 0;
            this.loginbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // password
            // 
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Font = new System.Drawing.Font("Myriad Pro", 12F);
            this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.password.Location = new System.Drawing.Point(47, 346);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(439, 42);
            this.password.TabIndex = 1;
            this.password.Text = "  Password";
            this.password.UseSystemPasswordChar = true;
            // 
            // username
            // 
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.username.Location = new System.Drawing.Point(47, 263);
            this.username.Multiline = true;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(439, 42);
            this.username.TabIndex = 0;
            this.username.Text = "  Username";
            // 
            // loginscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 596);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginscreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loginscreen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 loginbtn;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label forgetpassword;
        private System.Windows.Forms.Label rememberme;
        private Bunifu.Framework.UI.BunifuCheckbox remembermecheckbox;
        private System.Windows.Forms.Label createyouraccount;
        private System.Windows.Forms.Label donthaveanaccount;
    }
}