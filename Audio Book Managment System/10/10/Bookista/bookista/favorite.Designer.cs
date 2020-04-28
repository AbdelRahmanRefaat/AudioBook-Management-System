namespace bookista
{
    partial class favorite
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.favoritelist = new System.Windows.Forms.ListView();
            this.author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Narrator = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addbtn = new System.Windows.Forms.Button();
            this.addtxtbx = new Bunifu.Framework.BunifuCustomTextbox();
            this.SuspendLayout();
            // 
            // favoritelist
            // 
            this.favoritelist.BackColor = System.Drawing.Color.White;
            this.favoritelist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.author,
            this.bookname,
            this.type,
            this.Narrator});
            this.favoritelist.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.favoritelist.ForeColor = System.Drawing.Color.White;
            this.favoritelist.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.favoritelist.Location = new System.Drawing.Point(4, 14);
            this.favoritelist.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.favoritelist.Name = "favoritelist";
            this.favoritelist.Size = new System.Drawing.Size(1200, 625);
            this.favoritelist.TabIndex = 0;
            this.favoritelist.UseCompatibleStateImageBehavior = false;
            this.favoritelist.View = System.Windows.Forms.View.Details;
            this.favoritelist.SelectedIndexChanged += new System.EventHandler(this.favoritelist_SelectedIndexChanged);
            // 
            // author
            // 
            this.author.DisplayIndex = 1;
            this.author.Text = "Author";
            this.author.Width = 219;
            // 
            // bookname
            // 
            this.bookname.DisplayIndex = 0;
            this.bookname.Text = "Book Name";
            this.bookname.Width = 245;
            // 
            // type
            // 
            this.type.Text = "Category";
            this.type.Width = 253;
            // 
            // Narrator
            // 
            this.Narrator.Text = "Narrator";
            this.Narrator.Width = 212;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(208)))));
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addbtn.Location = new System.Drawing.Point(896, 651);
            this.addbtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(196, 50);
            this.addbtn.TabIndex = 60;
            this.addbtn.Text = "Add to favorite";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click_1);
            // 
            // addtxtbx
            // 
            this.addtxtbx.BackColor = System.Drawing.SystemColors.Control;
            this.addtxtbx.BorderColor = System.Drawing.Color.SeaGreen;
            this.addtxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addtxtbx.ForeColor = System.Drawing.SystemColors.Control;
            this.addtxtbx.Location = new System.Drawing.Point(54, 655);
            this.addtxtbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addtxtbx.Multiline = true;
            this.addtxtbx.Name = "addtxtbx";
            this.addtxtbx.Size = new System.Drawing.Size(809, 46);
            this.addtxtbx.TabIndex = 61;
            // 
            // favorite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.addtxtbx);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.favoritelist);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "favorite";
            this.Size = new System.Drawing.Size(1216, 715);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView favoritelist;
        private System.Windows.Forms.ColumnHeader author;
        private System.Windows.Forms.ColumnHeader bookname;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button addbtn;
        private Bunifu.Framework.BunifuCustomTextbox addtxtbx;
        private System.Windows.Forms.ColumnHeader Narrator;
    }
}
