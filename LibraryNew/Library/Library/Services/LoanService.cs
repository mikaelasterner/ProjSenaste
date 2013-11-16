using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Repositories;
using Library.Models;

namespace Library.Services
{
    class LoanService : IService<Loan>
    {
        readonly IRepository<Loan, int> _loanRepository;
        //för att komma åt add metoden i repository skapas en instans av repository


        public LoanService(IRepository<Loan, int> repository)
        {
            _loanRepository = repository;
        }

        public void Add(Loan loan)
        {
            _loanRepository.Add(loan);
            //utlös eventet för att lägga till en bok
        }

        public void Remove(Loan loan)
        {
            _loanRepository.Remove(loan);
            //utlös eventet för att lägga till en bok
        }

       

        public IEnumerable<Loan> GetDueLoans() {

            return _loanRepository.All().Where(loan => loan.DueDate < DateTime.Today && loan.ReturnTime == null);
        }

        public IEnumerable<Loan> GetActiveLoans()
        {
            return _loanRepository.All().Where(loan => loan.DueDate > DateTime.Today && loan.ReturnTime == null);
        }

        public IEnumerable<Loan> GetReturnedLoans()
        {
            return _loanRepository.All().Where(loan => loan.ReturnTime != null).OrderByDescending(loan => loan.ReturnTime);
        }

        
        public int ReturnLoan(Loan loan) {
            int returnFee = 0;
            if (loan.DueDate < DateTime.Today){
                returnFee = (DateTime.Today - loan.DueDate).Days * 10;
            }
            loan.ReturnTime = DateTime.Today;
            _loanRepository.Edit(loan);
            return returnFee;
        }


        public event EventHandler<ServiceEventArgs<Loan>> Updated;
        protected virtual void OnUpdate(ServiceEventArgs<Loan> ea)
        {
            if (Updated != null)
            {
                Updated(this, ea);
            }
        }

        public IEnumerable<Loan>  All()
        {
            return _loanRepository.All();
        }
    }
}