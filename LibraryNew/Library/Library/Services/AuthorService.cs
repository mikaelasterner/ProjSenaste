using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Repositories;
using Library.Models;

namespace Library.Services
{
    class AuthorService : IService
    {
        readonly IRepository<Author, int> _AuthorRepository;
        //för att komma åt add metoden i repository skapas en instans av repository
        //IRepository<Book, int> _BookRepository;

        public AuthorService(IRepository<Author, int> repository)
        {
            _AuthorRepository = repository;
           // _BookRepository = new RepositoryFactory().GetBookRepository();
        }

        public void Add(Author author)
        {
            _AuthorRepository.Add(author);
            //utlös eventet för att lägga till en bok
        }

        public void Remove(Author author)
        {
            _AuthorRepository.Remove(author);
            //utlös eventet för att lägga till en bok
        }

        public IEnumerable<Book> ListBookByAuthor(Author byAuthor)
        {
            //var ByAuthorList = _BookRepository.All().Where(book => book.Author.Id == ByAuthor.Id);
            var byAuthorList = byAuthor.Books;
            return byAuthorList;

        }
        public IEnumerable<Author> All()
        {
            return _AuthorRepository.All();
        }



        public event EventHandler Updated;

        protected virtual void OnUpdate(EventArgs ea)
        {
            if (Updated != null)
            {
                Updated(this, ea);
            }
        }
    }
}