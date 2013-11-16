﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
﻿using System.Runtime.InteropServices;
﻿using System.Runtime.Remoting.Channels;
﻿using System.Text;
using System.Windows.Forms;
using Library.Models;
using Library.Services;
using Library.Repositories;
using System.Data.Entity;

namespace Library
{
    public partial class LibraryForm : Form
    {
        BookService _bookservice;
        AuthorService _authorservice;
        BookCopyService _bookCopyService;
        MemberService _memberservice;
        LoanService _loanservice;
        IEnumerable<Object> listbox_data_backup;
        public LibraryForm()
        {
            
            InitializeComponent();

            
            // Uncomment the line you wish to use
            // Use a derived strategy with a Seed-method
            Database.SetInitializer<LibraryContext>(new LibraryDbInit());

            // Recreate the database only if the models change
            //Database.SetInitializer<LibraryContext>(new DropCreateDatabaseIfModelChanges<LibraryContext>());

            // Always drop and recreate the database
            //Database.SetInitializer<LibraryContext>(new DropCreateDatabaseAlways<LibraryContext>());

            rb_allbooks.CheckedChanged += (sender, args) =>
            {
                RadioButton rb = sender as RadioButton;
                if (rb.Checked)
                {
                    listbox_data_backup = _bookservice.All();
                    refresh_contents(listbox_data_backup);                  
                }
            };
            rb_allauthors.CheckedChanged += (sender, args) =>
            {
                RadioButton rb = sender as RadioButton;
                if (rb.Checked)
                {
                    listbox_data_backup = _authorservice.All();
                    refresh_contents(listbox_data_backup);                  
                }
            };

            rb_allmembers.CheckedChanged += (sender, args) =>
            {
                RadioButton rb = sender as RadioButton;
                if (rb.Checked)
                {
                    listbox_data_backup = _memberservice.All();
                    refresh_contents(listbox_data_backup);      
                }
            };
            rb_allloans.CheckedChanged += (sender, args) =>
            {
                RadioButton rb = sender as RadioButton;
                if (rb.Checked)
                {
                    listbox_data_backup = _loanservice.All();
                    refresh_contents(listbox_data_backup);
                   
                }
            };


            //BookRepository bookRepository = new RepositoryFactory().GetBookRepository();
            RepositoryFactory factory = new RepositoryFactory();
            _bookservice = new BookService(factory.GetBookRepository());
            _authorservice = new AuthorService(factory.GetAuthorRepository());
            _bookCopyService = new BookCopyService(factory.GetBookCopyRepository());
            _memberservice = new MemberService(factory.GetMemberRepository());
            _loanservice = new LoanService(factory.GetLoanRepository());

            Author a = new Author() { Name = "Anders Svensson" };
            Author b = new Author() { Name = "Anna Bok" };
            _authorservice.Add(a);
            _authorservice.Add(b);
            _bookservice.Add(new Book() { Title = "Mordet på greven", ISBN = "23329", Author = a });
            _bookservice.Add(new Book() { Title = "Mordet på Liselott", ISBN = "26629", Author = new Author { Name = "Gösta Ekman" } });
            _bookservice.Add(new Book() { Title = "Geven", ISBN = "98329", Author = a });
            Book bb = new Book() { Title = "Mordet på dennis", ISBN = "23329", Author = a };
            _bookservice.Add(bb);
            BookCopy bk = new BookCopy() {Book = bb };
            BookCopy bk1 = new BookCopy() { Book = bb };
            BookCopy bk2 = new BookCopy() { Book = bb };
            BookCopy bk3 = new BookCopy() { Book = bb };
            _bookCopyService.Add(bk);
            _bookCopyService.Add(bk1);
            _bookCopyService.Add(bk2);
            _bookCopyService.Add(bk3);
            _authorservice.Remove(b);

            
             Member dennis = new Member() {Name = "Dennis", PrId = 881011};
             _memberservice.Add(dennis);
             Member mikaela = new Member() { Name = "Mikaela", PrId = 860417 };
             _memberservice.Add(dennis);
            var loan = new Loan() { Member = dennis, Book_copy = bk, Time = DateTime.Today, DueDate = new DateTime(2013, 11, 11)};
            _loanservice.Add(loan);
            _loanservice.Add(new Loan() { Member = mikaela, Book_copy = bk2, Time = DateTime.Today, DueDate = (DateTime.Today.AddDays(15)) });
            int copies=_bookCopyService.getAvailableBookCopies(bb);
            var booklist = _authorservice.ListBookByAuthor(a);
            var dueloans = _loanservice.GetDueLoans();
            _memberservice.GetLoansForMember(new Member() {Name = "Dennisssssss", PrId = 8881011});
            _loanservice.ReturnLoan(loan);
            

        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            //show formulär för att adda AUthor
            panelAddAuthor.Visible = true;
        }

        private void btnEnterAuthor_Click(object sender, EventArgs e)
        {
            _authorservice.Add(new Author { Name=textboxAddAuthorName.Text});
            panelAddAuthor.Visible = false;
        }

        private void textbox_filter_TextChanged(object sender, EventArgs e)
        {
            var items = listbox_data_backup.Where(i => i.ToString().ToLower().Contains(textbox_filter.Text.ToLower())).ToList();
            
            refresh_contents(items);
        }

        private void refresh_contents(IEnumerable<object> contents)
        {

            listBox1.Items.Clear();
            foreach (var item in contents)
            {
                listBox1.Items.Add(item);
            }
        }
 }
}
