using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Models;

namespace Library.Repositories
{
    class BookCopyRepository : IRepository<BookCopy, int>
    {
        LibraryContext _context;

        public BookCopyRepository(LibraryContext context)
        {
            _context = context;
        }

        public void Add(BookCopy item)
        {
            //sparar bokkopian i databasen
            _context.BookCopies.Add(item);
            _context.SaveChanges();
        }

        public void Remove(BookCopy item)
        {
            //kontrollera så man inte tar bort en bokkopia som har lån?
            BookCopy BookCopyToRemove = _context.BookCopies.Find(item.Id);
            if(BookCopyToRemove != null)
                _context.BookCopies.Remove(BookCopyToRemove);
            _context.SaveChanges();
        }

        public BookCopy Find(int id)
        {
            BookCopy BookCopyToReturn = _context.BookCopies.Find(id);
            return BookCopyToReturn;
        }

        public void Edit(BookCopy item)
        {
            BookCopy BookCopyToEdit = _context.BookCopies.Find(item.Id);
            BookCopyToEdit.Book = item.Book;
            _context.SaveChanges();
        }

        public IEnumerable<BookCopy> All()
        {
            return _context.BookCopies.ToList<BookCopy>();
        }
    }
}