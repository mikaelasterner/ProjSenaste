using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Models;

namespace Library.Repositories
{
    class AuthorRepository : IRepository<Author, int>
    {
        LibraryContext _context;

        public AuthorRepository(LibraryContext context)
        {
            _context = context;
        }
        public void Add(Author item)
        {
            //sparar authorn i databasen
            _context.Authors.Add(item);
            _context.SaveChanges();
        }

        public void Remove(Author author)
        {
            Author AuthorToRemove = _context.Authors.Find(author.Id);
            if(AuthorToRemove!=null)
                _context.Authors.Remove(AuthorToRemove);
            _context.SaveChanges();
        }

        public Author Find(int id)
        {
            Author AuthorToReturn = _context.Authors.Find(id);
            return AuthorToReturn;
        }

        public void Edit(Author item)
        {
            Author AuthorToEdit = _context.Authors.Find(item.Id);
            AuthorToEdit.Name = item.Name;
            //kontrollera så inte listan med böcker är null, 
            //bör också kontrollera så författaren verkligen har skrivit de böcker som läggs till. /bör nog göras i services?
            if(item.Books!=null)
                AuthorToEdit.Books = item.Books;
            _context.SaveChanges();
        }

        public IEnumerable<Author> All()
        {
            return _context.Authors.ToList<Author>();
        }
    }
}