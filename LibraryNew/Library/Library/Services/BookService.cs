using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Repositories;
using Library.Models;

namespace Library.Services
{
    class BookService : IService<Book>
    {
        readonly IRepository<Book, int> _bookRepository;
       //för att komma åt add metoden i repository skapas en instans av repository


        public BookService(IRepository<Book, int> repository)
        {
            _bookRepository = repository;
        }

        public void Add(Book book)
        {
            _bookRepository.Add(book);
            //utlös eventet för att lägga till en bok
            OnUpdate(new ServiceEventArgs<Book>(Operation.Add, book, _bookRepository.All().Count()));
        }

        public void Remove(Book book)
        {
            _bookRepository.Remove(book);
            OnUpdate(new ServiceEventArgs<Book>(Operation.Remove, book, _bookRepository.All().Count()));
        }

        public Book Find(int id)
        {
            return _bookRepository.Find(id);
        }



        public IEnumerable<Book> All()
        {
            return _bookRepository.All();
        }

        public event EventHandler<ServiceEventArgs<Book>>  Updated;

        protected virtual void OnUpdate(ServiceEventArgs<Book> ea)
        {
            if (Updated != null)
            {
                Updated(this, ea);
            }
        }
    }
}
