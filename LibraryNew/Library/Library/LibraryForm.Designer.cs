namespace Library
{
    partial class LibraryForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel_rb_group = new System.Windows.Forms.Panel();
            this.rb_allauthors = new System.Windows.Forms.RadioButton();
            this.rb_allloans = new System.Windows.Forms.RadioButton();
            this.rb_allmembers = new System.Windows.Forms.RadioButton();
            this.rb_allbooks = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panelAddAuthor = new System.Windows.Forms.Panel();
            this.btnEnterAuthor = new System.Windows.Forms.Button();
            this.textboxAddAuthorName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_filter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_rb_group.SuspendLayout();
            this.panelAddAuthor.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(12, 100);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(359, 316);
            this.listBox1.TabIndex = 0;
            // 
            // panel_rb_group
            // 
            this.panel_rb_group.Controls.Add(this.rb_allauthors);
            this.panel_rb_group.Controls.Add(this.rb_allloans);
            this.panel_rb_group.Controls.Add(this.rb_allmembers);
            this.panel_rb_group.Controls.Add(this.rb_allbooks);
            this.panel_rb_group.Location = new System.Drawing.Point(12, 12);
            this.panel_rb_group.Name = "panel_rb_group";
            this.panel_rb_group.Size = new System.Drawing.Size(359, 46);
            this.panel_rb_group.TabIndex = 1;
            // 
            // rb_allauthors
            // 
            this.rb_allauthors.AutoSize = true;
            this.rb_allauthors.Location = new System.Drawing.Point(91, 16);
            this.rb_allauthors.Name = "rb_allauthors";
            this.rb_allauthors.Size = new System.Drawing.Size(61, 17);
            this.rb_allauthors.TabIndex = 3;
            this.rb_allauthors.TabStop = true;
            this.rb_allauthors.Text = "Authors";
            this.rb_allauthors.UseVisualStyleBackColor = true;
            // 
            // rb_allloans
            // 
            this.rb_allloans.AutoSize = true;
            this.rb_allloans.Location = new System.Drawing.Point(272, 16);
            this.rb_allloans.Name = "rb_allloans";
            this.rb_allloans.Size = new System.Drawing.Size(54, 17);
            this.rb_allloans.TabIndex = 2;
            this.rb_allloans.TabStop = true;
            this.rb_allloans.Text = "Loans";
            this.rb_allloans.UseVisualStyleBackColor = true;
            // 
            // rb_allmembers
            // 
            this.rb_allmembers.AutoSize = true;
            this.rb_allmembers.Location = new System.Drawing.Point(177, 16);
            this.rb_allmembers.Name = "rb_allmembers";
            this.rb_allmembers.Size = new System.Drawing.Size(68, 17);
            this.rb_allmembers.TabIndex = 1;
            this.rb_allmembers.TabStop = true;
            this.rb_allmembers.Text = "Members";
            this.rb_allmembers.UseVisualStyleBackColor = true;
            // 
            // rb_allbooks
            // 
            this.rb_allbooks.AutoSize = true;
            this.rb_allbooks.Location = new System.Drawing.Point(4, 16);
            this.rb_allbooks.Name = "rb_allbooks";
            this.rb_allbooks.Size = new System.Drawing.Size(68, 17);
            this.rb_allbooks.TabIndex = 0;
            this.rb_allbooks.TabStop = true;
            this.rb_allbooks.Text = "All books";
            this.rb_allbooks.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(390, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 49);
            this.button2.TabIndex = 3;
            this.button2.Text = "Add Book";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(390, 173);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 49);
            this.button4.TabIndex = 5;
            this.button4.Text = "Add Member";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Location = new System.Drawing.Point(511, 102);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(98, 49);
            this.btnAddAuthor.TabIndex = 6;
            this.btnAddAuthor.Text = "Add Author";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(511, 173);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(98, 49);
            this.button6.TabIndex = 7;
            this.button6.Text = "Add Loan";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(390, 239);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(98, 49);
            this.button7.TabIndex = 8;
            this.button7.Text = "Return Loan";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // panelAddAuthor
            // 
            this.panelAddAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAddAuthor.Controls.Add(this.btnEnterAuthor);
            this.panelAddAuthor.Controls.Add(this.textboxAddAuthorName);
            this.panelAddAuthor.Controls.Add(this.label2);
            this.panelAddAuthor.Controls.Add(this.label1);
            this.panelAddAuthor.Location = new System.Drawing.Point(659, 100);
            this.panelAddAuthor.Name = "panelAddAuthor";
            this.panelAddAuthor.Size = new System.Drawing.Size(200, 316);
            this.panelAddAuthor.TabIndex = 10;
            this.panelAddAuthor.Visible = false;
            // 
            // btnEnterAuthor
            // 
            this.btnEnterAuthor.Location = new System.Drawing.Point(6, 93);
            this.btnEnterAuthor.Name = "btnEnterAuthor";
            this.btnEnterAuthor.Size = new System.Drawing.Size(98, 49);
            this.btnEnterAuthor.TabIndex = 11;
            this.btnEnterAuthor.Text = "Enter";
            this.btnEnterAuthor.UseVisualStyleBackColor = true;
            this.btnEnterAuthor.Click += new System.EventHandler(this.btnEnterAuthor_Click);
            // 
            // textboxAddAuthorName
            // 
            this.textboxAddAuthorName.Location = new System.Drawing.Point(6, 52);
            this.textboxAddAuthorName.Name = "textboxAddAuthorName";
            this.textboxAddAuthorName.Size = new System.Drawing.Size(100, 20);
            this.textboxAddAuthorName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Author";
            // 
            // textbox_filter
            // 
            this.textbox_filter.Location = new System.Drawing.Point(47, 79);
            this.textbox_filter.Name = "textbox_filter";
            this.textbox_filter.Size = new System.Drawing.Size(100, 20);
            this.textbox_filter.TabIndex = 11;
            this.textbox_filter.TextChanged += new System.EventHandler(this.textbox_filter_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Filter:";
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 463);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textbox_filter);
            this.Controls.Add(this.panelAddAuthor);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnAddAuthor);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel_rb_group);
            this.Controls.Add(this.listBox1);
            this.Name = "LibraryForm";
            this.Text = "LibraryForm";
            this.panel_rb_group.ResumeLayout(false);
            this.panel_rb_group.PerformLayout();
            this.panelAddAuthor.ResumeLayout(false);
            this.panelAddAuthor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel_rb_group;
        private System.Windows.Forms.RadioButton rb_allloans;
        private System.Windows.Forms.RadioButton rb_allmembers;
        private System.Windows.Forms.RadioButton rb_allbooks;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panelAddAuthor;
        private System.Windows.Forms.TextBox textboxAddAuthorName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnterAuthor;
        private System.Windows.Forms.RadioButton rb_allauthors;
        private System.Windows.Forms.TextBox textbox_filter;
        private System.Windows.Forms.Label label3;
    }
}