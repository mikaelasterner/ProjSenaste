﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Library.Models;
using Library.Services;
using Library.Repositories;
using System.Data.Entity;

namespace Library
{
    public partial class LibraryForm : Form
    {
        public LibraryForm()
        {
            BookService _bookservice;
            AuthorService _authorservice;
            BookCopyService _bookCopyService;
            MemberService _memberservice;
            LoanService _loanservice;
            InitializeComponent();


            // Uncomment the line you wish to use
            // Use a derived strategy with a Seed-method
            Database.SetInitializer<LibraryContext>(new LibraryDbInit());

            // Recreate the database only if the models change
            //Database.SetInitializer<LibraryContext>(new DropCreateDatabaseIfModelChanges<LibraryContext>());

            // Always drop and recreate the database
            //Database.SetInitializer<LibraryContext>(new DropCreateDatabaseAlways<LibraryContext>());




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
            _bookservice.Add(new Book() { Title = "Geven", ISBN = "98329" });
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

            _memberservice.Add(new Member() {Name = "Dennis", PrId = 860417});
            _loanservice.Add(new Loan() { Member = new Member() {Name = "Dennis", PrId = 880417}, Book_copy = bk} );
            _loanservice.Add(new Loan() { Member = new Member() { Name = "Dennis", PrId = 800417 }, Book_copy = bk2 });
            int copies=_bookCopyService.getAvailableBookCopies(bb);

        }
        
    }
}
