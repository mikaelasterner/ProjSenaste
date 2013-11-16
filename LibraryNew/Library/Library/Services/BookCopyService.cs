﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Repositories;
using Library.Models;

namespace Library.Services
{
    class BookCopyService : IService<BookCopy>
    {
        readonly IRepository<BookCopy, int> _bookCopyRepository;
        //för att komma åt add metoden i repository skapas en instans av repository
        readonly IRepository<Loan, int> _loanRepository;

        public BookCopyService(IRepository<BookCopy, int> repository)
        {
            _bookCopyRepository = repository;
            _loanRepository = new RepositoryFactory().GetLoanRepository();
        }

        public int getAvailableBookCopies(Book book){
            //leta upp böcker som är returnerade 
            var BookCopyList = _bookCopyRepository.All().Where(bk => bk.Book.Id == book.Id);
            var LoanList = _loanRepository.All().Where(loan => loan.Book_copy.Book.Id == book.Id && loan.ReturnTime == null);
            int antalUtlånade = LoanList.Count();
            return BookCopyList.Count() - antalUtlånade;
            //kan även lista en lista på alla bokkopior beroende på vad vi specifiserar
        }

        public IEnumerable<BookCopy> getBookCopies(Book book)
        {
            var BookCopyList = _bookCopyRepository.All();
            BookCopyList = BookCopyList.Where(bc => bc.Book.Id == book.Id);
            return BookCopyList;
        }

        public void Add(BookCopy copy)
        {
            _bookCopyRepository.Add(copy);
            //utlös eventet för att lägga till en bok
        }

        public void Remove(BookCopy copy)
        {
            _bookCopyRepository.Remove(copy);
            //utlös eventet för att lägga till en bok
        }

        public event EventHandler<ServiceEventArgs<BookCopy>>  Updated;

        protected virtual void OnUpdate(ServiceEventArgs<BookCopy> ea)
        {
            if (Updated != null)
            {
                Updated(this, ea);
            }
        }
    }
}