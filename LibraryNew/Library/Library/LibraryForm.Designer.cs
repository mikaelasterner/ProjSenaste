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
            this.btn_AddBook = new System.Windows.Forms.Button();
            this.btn_AddMember = new System.Windows.Forms.Button();
            this.btn_AddAuthor = new System.Windows.Forms.Button();
            this.btn_AddLoan = new System.Windows.Forms.Button();
            this.btn_ReturnLoan = new System.Windows.Forms.Button();
            this.panel_AddAuthor = new System.Windows.Forms.Panel();
            this.btnEnterAuthor = new System.Windows.Forms.Button();
            this.textboxAddAuthorName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_AddBook = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_addbook = new System.Windows.Forms.Label();
            this.textbox_filter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_mother = new System.Windows.Forms.Panel();
            this.panel_AddMember = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textbox_AddMember_SSN = new System.Windows.Forms.TextBox();
            this.btn_AddMember_Add = new System.Windows.Forms.Button();
            this.textbox_AddMember_Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_AddMember = new System.Windows.Forms.Label();
            this.panel_AddLoan = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_AddLoan = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel_rb_group.SuspendLayout();
            this.panel_AddAuthor.SuspendLayout();
            this.panel_AddBook.SuspendLayout();
            this.panel_mother.SuspendLayout();
            this.panel_AddMember.SuspendLayout();
            this.panel_AddLoan.SuspendLayout();
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
            // btn_AddBook
            // 
            this.btn_AddBook.Location = new System.Drawing.Point(390, 100);
            this.btn_AddBook.Name = "btn_AddBook";
            this.btn_AddBook.Size = new System.Drawing.Size(98, 49);
            this.btn_AddBook.TabIndex = 3;
            this.btn_AddBook.Text = "Add Book";
            this.btn_AddBook.UseVisualStyleBackColor = true;
            this.btn_AddBook.Click += new System.EventHandler(this.btn_AddBook_Click);
            // 
            // btn_AddMember
            // 
            this.btn_AddMember.Location = new System.Drawing.Point(390, 173);
            this.btn_AddMember.Name = "btn_AddMember";
            this.btn_AddMember.Size = new System.Drawing.Size(98, 49);
            this.btn_AddMember.TabIndex = 5;
            this.btn_AddMember.Text = "Add Member";
            this.btn_AddMember.UseVisualStyleBackColor = true;
            this.btn_AddMember.Click += new System.EventHandler(this.btn_AddMember_Click);
            // 
            // btn_AddAuthor
            // 
            this.btn_AddAuthor.Location = new System.Drawing.Point(511, 100);
            this.btn_AddAuthor.Name = "btn_AddAuthor";
            this.btn_AddAuthor.Size = new System.Drawing.Size(98, 49);
            this.btn_AddAuthor.TabIndex = 6;
            this.btn_AddAuthor.Text = "Add Author";
            this.btn_AddAuthor.UseVisualStyleBackColor = true;
            this.btn_AddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // btn_AddLoan
            // 
            this.btn_AddLoan.Location = new System.Drawing.Point(511, 173);
            this.btn_AddLoan.Name = "btn_AddLoan";
            this.btn_AddLoan.Size = new System.Drawing.Size(98, 49);
            this.btn_AddLoan.TabIndex = 7;
            this.btn_AddLoan.Text = "Add Loan";
            this.btn_AddLoan.UseVisualStyleBackColor = true;
            this.btn_AddLoan.Click += new System.EventHandler(this.btn_AddLoan_Click);
            // 
            // btn_ReturnLoan
            // 
            this.btn_ReturnLoan.Location = new System.Drawing.Point(390, 239);
            this.btn_ReturnLoan.Name = "btn_ReturnLoan";
            this.btn_ReturnLoan.Size = new System.Drawing.Size(98, 49);
            this.btn_ReturnLoan.TabIndex = 8;
            this.btn_ReturnLoan.Text = "Return Loan";
            this.btn_ReturnLoan.UseVisualStyleBackColor = true;
            // 
            // panel_AddAuthor
            // 
            this.panel_AddAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_AddAuthor.Controls.Add(this.btnEnterAuthor);
            this.panel_AddAuthor.Controls.Add(this.textboxAddAuthorName);
            this.panel_AddAuthor.Controls.Add(this.label2);
            this.panel_AddAuthor.Controls.Add(this.label1);
            this.panel_AddAuthor.Location = new System.Drawing.Point(22, 100);
            this.panel_AddAuthor.Name = "panel_AddAuthor";
            this.panel_AddAuthor.Size = new System.Drawing.Size(200, 316);
            this.panel_AddAuthor.TabIndex = 10;
            this.panel_AddAuthor.Visible = false;
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
            // panel_AddBook
            // 
            this.panel_AddBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_AddBook.Controls.Add(this.button1);
            this.panel_AddBook.Controls.Add(this.textBox1);
            this.panel_AddBook.Controls.Add(this.label4);
            this.panel_AddBook.Controls.Add(this.lbl_addbook);
            this.panel_AddBook.Location = new System.Drawing.Point(22, 100);
            this.panel_AddBook.Name = "panel_AddBook";
            this.panel_AddBook.Size = new System.Drawing.Size(200, 316);
            this.panel_AddBook.TabIndex = 12;
            this.panel_AddBook.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 49);
            this.button1.TabIndex = 11;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Title:";
            // 
            // lbl_addbook
            // 
            this.lbl_addbook.AutoSize = true;
            this.lbl_addbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addbook.Location = new System.Drawing.Point(3, 0);
            this.lbl_addbook.Name = "lbl_addbook";
            this.lbl_addbook.Size = new System.Drawing.Size(62, 13);
            this.lbl_addbook.TabIndex = 0;
            this.lbl_addbook.Text = "Add Book";
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
            // panel_mother
            // 
            this.panel_mother.Controls.Add(this.panel_AddLoan);
            this.panel_mother.Controls.Add(this.panel_AddMember);
            this.panel_mother.Controls.Add(this.panel_AddAuthor);
            this.panel_mother.Controls.Add(this.panel_AddBook);
            this.panel_mother.Location = new System.Drawing.Point(615, 0);
            this.panel_mother.Name = "panel_mother";
            this.panel_mother.Size = new System.Drawing.Size(279, 501);
            this.panel_mother.TabIndex = 13;
            // 
            // panel_AddMember
            // 
            this.panel_AddMember.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_AddMember.Controls.Add(this.label6);
            this.panel_AddMember.Controls.Add(this.textbox_AddMember_SSN);
            this.panel_AddMember.Controls.Add(this.btn_AddMember_Add);
            this.panel_AddMember.Controls.Add(this.textbox_AddMember_Name);
            this.panel_AddMember.Controls.Add(this.label5);
            this.panel_AddMember.Controls.Add(this.lbl_AddMember);
            this.panel_AddMember.Location = new System.Drawing.Point(22, 100);
            this.panel_AddMember.Name = "panel_AddMember";
            this.panel_AddMember.Size = new System.Drawing.Size(200, 316);
            this.panel_AddMember.TabIndex = 12;
            this.panel_AddMember.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "# SSN (ex. 881211-5844)";
            // 
            // textbox_AddMember_SSN
            // 
            this.textbox_AddMember_SSN.Location = new System.Drawing.Point(6, 94);
            this.textbox_AddMember_SSN.Name = "textbox_AddMember_SSN";
            this.textbox_AddMember_SSN.Size = new System.Drawing.Size(100, 20);
            this.textbox_AddMember_SSN.TabIndex = 12;
            // 
            // btn_AddMember_Add
            // 
            this.btn_AddMember_Add.Location = new System.Drawing.Point(6, 120);
            this.btn_AddMember_Add.Name = "btn_AddMember_Add";
            this.btn_AddMember_Add.Size = new System.Drawing.Size(98, 49);
            this.btn_AddMember_Add.TabIndex = 11;
            this.btn_AddMember_Add.Text = "Enter";
            this.btn_AddMember_Add.UseVisualStyleBackColor = true;
            // 
            // textbox_AddMember_Name
            // 
            this.textbox_AddMember_Name.Location = new System.Drawing.Point(6, 52);
            this.textbox_AddMember_Name.Name = "textbox_AddMember_Name";
            this.textbox_AddMember_Name.Size = new System.Drawing.Size(100, 20);
            this.textbox_AddMember_Name.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Name:";
            // 
            // lbl_AddMember
            // 
            this.lbl_AddMember.AutoSize = true;
            this.lbl_AddMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddMember.Location = new System.Drawing.Point(3, 0);
            this.lbl_AddMember.Name = "lbl_AddMember";
            this.lbl_AddMember.Size = new System.Drawing.Size(77, 13);
            this.lbl_AddMember.TabIndex = 0;
            this.lbl_AddMember.Text = "Add Member";
            // 
            // panel_AddLoan
            // 
            this.panel_AddLoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_AddLoan.Controls.Add(this.label8);
            this.panel_AddLoan.Controls.Add(this.label7);
            this.panel_AddLoan.Controls.Add(this.textBox2);
            this.panel_AddLoan.Controls.Add(this.button2);
            this.panel_AddLoan.Controls.Add(this.lbl_AddLoan);
            this.panel_AddLoan.Location = new System.Drawing.Point(22, 100);
            this.panel_AddLoan.Name = "panel_AddLoan";
            this.panel_AddLoan.Size = new System.Drawing.Size(200, 316);
            this.panel_AddLoan.TabIndex = 14;
            this.panel_AddLoan.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "# SSN (ex. 881211-5844)";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 49);
            this.button2.TabIndex = 11;
            this.button2.Text = "Enter";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lbl_AddLoan
            // 
            this.lbl_AddLoan.AutoSize = true;
            this.lbl_AddLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddLoan.Location = new System.Drawing.Point(3, 0);
            this.lbl_AddLoan.Name = "lbl_AddLoan";
            this.lbl_AddLoan.Size = new System.Drawing.Size(61, 13);
            this.lbl_AddLoan.TabIndex = 0;
            this.lbl_AddLoan.Text = "Add Loan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Book:";
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 463);
            this.Controls.Add(this.panel_mother);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textbox_filter);
            this.Controls.Add(this.btn_ReturnLoan);
            this.Controls.Add(this.btn_AddLoan);
            this.Controls.Add(this.btn_AddAuthor);
            this.Controls.Add(this.btn_AddMember);
            this.Controls.Add(this.btn_AddBook);
            this.Controls.Add(this.panel_rb_group);
            this.Controls.Add(this.listBox1);
            this.Name = "LibraryForm";
            this.Text = "Mickans Bibliotek";

            this.panel_rb_group.ResumeLayout(false);
            this.panel_rb_group.PerformLayout();

            this.panel_AddAuthor.ResumeLayout(false);
            this.panel_AddAuthor.PerformLayout();

            this.panel_AddBook.ResumeLayout(false);
            this.panel_AddBook.PerformLayout();

            this.panel_mother.ResumeLayout(false);

            this.panel_AddMember.ResumeLayout(false);
            this.panel_AddMember.PerformLayout();

            this.panel_AddLoan.ResumeLayout(false);
            this.panel_AddLoan.PerformLayout();

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel_rb_group;
        private System.Windows.Forms.RadioButton rb_allloans;
        private System.Windows.Forms.RadioButton rb_allmembers;
        private System.Windows.Forms.RadioButton rb_allbooks;
        private System.Windows.Forms.Button btn_AddBook;
        private System.Windows.Forms.Button btn_AddMember;
        private System.Windows.Forms.Button btn_AddAuthor;
        private System.Windows.Forms.Button btn_AddLoan;
        private System.Windows.Forms.Button btn_ReturnLoan;
        private System.Windows.Forms.Panel panel_AddAuthor;
        private System.Windows.Forms.TextBox textboxAddAuthorName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnterAuthor;
        private System.Windows.Forms.RadioButton rb_allauthors;
        private System.Windows.Forms.TextBox textbox_filter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_mother;
        private System.Windows.Forms.Panel panel_AddBook;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_addbook;
        private System.Windows.Forms.Panel panel_AddMember;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textbox_AddMember_SSN;
        private System.Windows.Forms.Button btn_AddMember_Add;
        private System.Windows.Forms.TextBox textbox_AddMember_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_AddMember;
        private System.Windows.Forms.Panel panel_AddLoan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_AddLoan;
    }
}