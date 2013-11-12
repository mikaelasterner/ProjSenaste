using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Models;

namespace Library.Repositories
{
    class LoanRepository : IRepository<Loan, int>
    {
        LibraryContext _context;

        public LoanRepository(LibraryContext context)
        {
            _context = context;
        }

        public void Add(Loan loan)
        {
            //sparar bok i databasen
            _context.Loans.Add(loan);
            _context.SaveChanges();
        }

        public void Remove(Loan loan)
        {
            //vi får inte ta bort lån enligt spcifikationern
            Loan LoanToRemove = _context.Loans.Find(loan.Id);
            if(LoanToRemove != null)
                _context.Loans.Remove(LoanToRemove);
            _context.SaveChanges();
        }

        public Loan Find(int id)
        {
            Loan LoanToReturn = _context.Loans.Find(id);
            return LoanToReturn;
        }

        public void Edit(Loan item)
        {
            Loan LoanToEdit = _context.Loans.Find(item.Id);
            LoanToEdit.Time = item.Time;
            LoanToEdit.DueDate = item.DueDate;
            LoanToEdit.Book_copy = LoanToEdit.Book_copy;
            LoanToEdit.Member = LoanToEdit.Member;
            if (item.ReturnTime != null)
                LoanToEdit.ReturnTime = LoanToEdit.ReturnTime;
            _context.SaveChanges();
        }

        public IEnumerable<Loan> All()
        {
            return _context.Loans.ToList<Loan>();
        }
    }
}