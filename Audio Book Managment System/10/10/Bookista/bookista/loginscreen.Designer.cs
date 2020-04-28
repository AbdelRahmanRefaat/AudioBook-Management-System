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
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.forgetpassword1 = new bookista.forgetpassword();
            this.registration1 = new bookista.registration();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.forgetpassword = new System.Windows.Forms.Label();
            this.rememberme = new System.Windows.Forms.Label();
            this.remembermecheckbox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.createyouraccount = new System.Windows.Forms.Label();
            this.donthaveanaccount = new System.Windows.Forms.Label();
            this.loginbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 13;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.forgetpassword1);
            this.panel1.Controls.Add(this.registration1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 596);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // forgetpassword1
            // 
            this.forgetpassword1.BackColor = System.Drawing.Color.White;
            this.forgetpassword1.Location = new System.Drawing.Point(0, 130);
            this.forgetpassword1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.forgetpassword1.Name = "forgetpassword1";
            this.forgetpassword1.Size = new System.Drawing.Size(493, 465);
            this.forgetpassword1.TabIndex = 12;
            this.forgetpassword1.Load += new System.EventHandler(this.forgetpassword1_Load_2);
            // 
            // registration1
            // 
            this.registration1.BackColor = System.Drawing.Color.White;
            this.registration1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.registration1.Location = new System.Drawing.Point(3, 130);
            this.registration1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registration1.Name = "registration1";
            this.registration1.Size = new System.Drawing.Size(499, 465);
            this.registration1.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(47)))), ((int)(((byte)(209)))));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1009, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 34);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(47)))), ((int)(((byte)(209)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(972, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 34);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // forgetpassword
            // 
            this.forgetpassword.AutoSize = true;
            this.forgetpassword.BackColor = System.Drawing.Color.White;
            this.forgetpassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgetpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgetpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.forgetpassword.Location = new System.Drawing.Point(312, 438);
            this.forgetpassword.Name = "forgetpassword";
            this.forgetpassword.Size = new System.Drawing.Size(161, 24);
            this.forgetpassword.TabIndex = 7;
            this.forgetpassword.Text = "Forgot password?";
            this.forgetpassword.Click += new System.EventHandler(this.forgetpassword_Click);
            // 
            // rememberme
            // 
            this.rememberme.AutoSize = true;
            this.rememberme.BackColor = System.Drawing.Color.White;
            this.rememberme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rememberme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.rememberme.Location = new System.Drawing.Point(75, 438);
            this.rememberme.Name = "rememberme";
            this.rememberme.Size = new System.Drawing.Size(137, 24);
            this.rememberme.TabIndex = 6;
            this.rememberme.Text = "Remember Me";
            this.rememberme.Click += new System.EventHandler(this.rememberme_Click);
            // 
            // remembermecheckbox
            // 
            this.remembermecheckbox.BackColor = System.Drawing.Color.White;
            this.remembermecheckbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.remembermecheckbox.ChechedOffColor = System.Drawing.Color.White;
            this.remembermecheckbox.Checked = false;
            this.remembermecheckbox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(71)))), ((int)(((byte)(220)))));
            this.remembermecheckbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.remembermecheckbox.ForeColor = System.Drawing.Color.White;
            this.remembermecheckbox.Location = new System.Drawing.Point(47, 438);
            this.remembermecheckbox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.remembermecheckbox.Name = "remembermecheckbox";
            this.remembermecheckbox.Size = new System.Drawing.Size(20, 20);
            this.remembermecheckbox.TabIndex = 5;
            this.remembermecheckbox.Tag = "";
            this.remembermecheckbox.OnChange += new System.EventHandler(this.remembermecheckbox_OnChange_1);
            // 
            // createyouraccount
            // 
            this.createyouraccount.AutoSize = true;
            this.createyouraccount.BackColor = System.Drawing.Color.White;
            this.createyouraccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createyouraccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createyouraccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(54)))), ((int)(((byte)(213)))));
            this.createyouraccount.Location = new System.Drawing.Point(256, 196);
            this.createyouraccount.Name = "createyouraccount";
            this.createyouraccount.Size = new System.Drawing.Size(179, 24);
            this.createyouraccount.TabIndex = 4;
            this.createyouraccount.Text = "Create your account";
            this.createyouraccount.Click += new System.EventHandler(this.createyouraccount_Click);
            // 
            // donthaveanaccount
            // 
            this.donthaveanaccount.AutoSize = true;
            this.donthaveanaccount.BackColor = System.Drawing.Color.White;
            this.donthaveanaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donthaveanaccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.donthaveanaccount.Location = new System.Drawing.Point(43, 196);
            this.donthaveanaccount.Name = "donthaveanaccount";
            this.donthaveanaccount.Size = new System.Drawing.Size(207, 24);
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
            this.loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.loginbtn.IdleBorderThickness = 1;
            this.loginbtn.IdleCornerRadius = 35;
            this.loginbtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(71)))), ((int)(((byte)(220)))));
            this.loginbtn.IdleForecolor = System.Drawing.Color.White;
            this.loginbtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(71)))), ((int)(((byte)(220)))));
            this.loginbtn.Location = new System.Drawing.Point(320, 481);
            this.loginbtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(153, 66);
            this.loginbtn.TabIndex = 0;
            this.loginbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click_1);
            // 
            // password
            // 
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.Silver;
            this.password.Location = new System.Drawing.Point(47, 346);
            this.password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(439, 42);
            this.password.TabIndex = 1;
            this.password.Text = "  Password";
            this.password.UseSystemPasswordChar = true;
            this.password.Click += new System.EventHandler(this.password_Click);
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged_1);
            // 
            // username
            // 
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.Silver;
            this.username.Location = new System.Drawing.Point(47, 263);
            this.username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.username.Multiline = true;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(439, 42);
            this.username.TabIndex = 0;
            this.username.Text = "  Username";
            this.username.Click += new System.EventHandler(this.username_Click);
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged_1);
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this;
            this.bunifuDragControl2.Vertical = true;
            // 
            // loginscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 596);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "loginscreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loginscreen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 loginbtn;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label forgetpassword;
        private System.Windows.Forms.Label rememberme;
        private Bunifu.Framework.UI.BunifuCheckbox remembermecheckbox;
        private System.Windows.Forms.Label createyouraccount;
        private System.Windows.Forms.Label donthaveanaccount;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private registration registration1;
        private forgetpassword forgetpassword1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
    }
}