using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Repositories;
using Library.Models;

namespace Library.Services
{
    class AuthorService : IService<Author>
    {
        readonly IRepository<Author, int> _authorRepository;
        //för att komma åt add metoden i repository skapas en instans av repository
        //IRepository<Book, int> _BookRepository;

        public AuthorService(IRepository<Author, int> repository)
        {
            _authorRepository = repository;
           // _BookRepository = new RepositoryFactory().GetBookRepository();
        }

        public void Add(Author author)
        {
            _authorRepository.Add(author);
            //utlös eventet för att lägga till en bok
            OnUpdate(new ServiceEventArgs<Author>(Operation.Add, author, _authorRepository.All().Count()));
        }

        public void Remove(Author author)
        {
            _authorRepository.Remove(author);
            //utlös eventet för att lägga till en bok
            OnUpdate(new ServiceEventArgs<Author>(Operation.Remove, author, _authorRepository.All().Count()));
        }

        public IEnumerable<Book> ListBookByAuthor(Author byAuthor)
        {
            //var ByAuthorList = _BookRepository.All().Where(book => book.Author.Id == ByAuthor.Id);
            var byAuthorList = byAuthor.Books;
            return byAuthorList;

        }
        public IEnumerable<Author> All()
        {
            return _authorRepository.All();
        }



        public event EventHandler<ServiceEventArgs<Author>> Updated;

        protected virtual void OnUpdate(ServiceEventArgs<Author> ea)
        {
            if (Updated != null)
            {
                Updated(this, ea);
            }
        }
    }
}