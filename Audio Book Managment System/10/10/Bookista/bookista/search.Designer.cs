namespace bookista
{
    partial class search
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.list = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.narrator = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.byauthor = new System.Windows.Forms.RadioButton();
            this.bynarrator = new System.Windows.Forms.RadioButton();
            this.byname = new System.Windows.Forms.RadioButton();
            this.bycategory = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(44, 39);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(641, 38);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // list
            // 
            this.list.BackColor = System.Drawing.SystemColors.Control;
            this.list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.author,
            this.narrator,
            this.category});
            this.list.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.list.ForeColor = System.Drawing.Color.White;
            this.list.Location = new System.Drawing.Point(44, 104);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(1137, 593);
            this.list.TabIndex = 2;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.Text = "Book Name";
            this.name.Width = 193;
            // 
            // author
            // 
            this.author.Text = "Author";
            this.author.Width = 167;
            // 
            // narrator
            // 
            this.narrator.Text = "Narrator";
            this.narrator.Width = 169;
            // 
            // category
            // 
            this.category.Text = "Category";
            this.category.Width = 194;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(106)))), ((int)(((byte)(208)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(702, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // byauthor
            // 
            this.byauthor.AutoSize = true;
            this.byauthor.BackColor = System.Drawing.SystemColors.Control;
            this.byauthor.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.byauthor.Font = new System.Drawing.Font("Tahoma", 10F);
            this.byauthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.byauthor.Location = new System.Drawing.Point(1041, 27);
            this.byauthor.Name = "byauthor";
            this.byauthor.Size = new System.Drawing.Size(79, 25);
            this.byauthor.TabIndex = 4;
            this.byauthor.Text = "author";
            this.byauthor.UseVisualStyleBackColor = false;
            this.byauthor.CheckedChanged += new System.EventHandler(this.byauthor_CheckedChanged);
            // 
            // bynarrator
            // 
            this.bynarrator.AutoSize = true;
            this.bynarrator.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bynarrator.Font = new System.Drawing.Font("Tahoma", 10F);
            this.bynarrator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bynarrator.Location = new System.Drawing.Point(885, 58);
            this.bynarrator.Name = "bynarrator";
            this.bynarrator.Size = new System.Drawing.Size(91, 25);
            this.bynarrator.TabIndex = 5;
            this.bynarrator.Text = "narrator";
            this.bynarrator.UseVisualStyleBackColor = true;
            this.bynarrator.CheckedChanged += new System.EventHandler(this.bynarrator_CheckedChanged);
            // 
            // byname
            // 
            this.byname.AutoSize = true;
            this.byname.Checked = true;
            this.byname.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.byname.Font = new System.Drawing.Font("Tahoma", 10F);
            this.byname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.byname.Location = new System.Drawing.Point(885, 27);
            this.byname.Name = "byname";
            this.byname.Size = new System.Drawing.Size(107, 25);
            this.byname.TabIndex = 6;
            this.byname.TabStop = true;
            this.byname.Text = "bookname";
            this.byname.UseVisualStyleBackColor = true;
            this.byname.CheckedChanged += new System.EventHandler(this.byname_CheckedChanged);
            // 
            // bycategory
            // 
            this.bycategory.AutoSize = true;
            this.bycategory.BackColor = System.Drawing.SystemColors.Control;
            this.bycategory.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bycategory.Font = new System.Drawing.Font("Tahoma", 10F);
            this.bycategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bycategory.Location = new System.Drawing.Point(1041, 58);
            this.bycategory.Name = "bycategory";
            this.bycategory.Size = new System.Drawing.Size(95, 25);
            this.bycategory.TabIndex = 7;
            this.bycategory.Text = "category";
            this.bycategory.UseVisualStyleBackColor = false;
            this.bycategory.CheckedChanged += new System.EventHandler(this.bycategory_CheckedChanged);
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.bycategory);
            this.Controls.Add(this.byname);
            this.Controls.Add(this.bynarrator);
            this.Controls.Add(this.byauthor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.list);
            this.Controls.Add(this.richTextBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.Name = "search";
            this.Size = new System.Drawing.Size(1216, 715);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader author;
        private System.Windows.Forms.ColumnHeader narrator;
        private System.Windows.Forms.ColumnHeader category;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton byauthor;
        private System.Windows.Forms.RadioButton bynarrator;
        private System.Windows.Forms.RadioButton byname;
        private System.Windows.Forms.RadioButton bycategory;
    }
}
