﻿/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Models;

namespace Library.Repositories
{
   class BookRepository : IRepository<Book, int>
    {
        LibraryContext _context;

        public BookRepository(LibraryContext context)
        {
            _context = context;
        }

        public void Add(Book item)
        {
            //sparar bok i databasen
            _context.Books.Add(item);
            _context.SaveChanges();
        }

        public void Remove(Book item)
        {
            _context.Books.Remove(item);
            _context.SaveChanges();
        }

      //  public Book Find(Tid id)
        //{
          //  Book bok = null;
            //hittar en bok
           // return bok;

        //}
        public void Edit(Book item)
        {
            //uppdaterar en book
        }
       // public IEnumerable<Book> All()
        //{
        //    
        //    //returnerar en lista med alla element
        //    return books;
        //}

        public IEnumerable<Book> All()
        {
            return _context.Books;
        }
        public Book Find(int bookId)
        {
            Book book = _context.Books.Find(bookId);
            return book;
        }
   }
}*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Models;

namespace Library.Repositories
{
    class BookRepository : IRepository<Book, int>
    {
        readonly LibraryContext _context;

        public BookRepository(LibraryContext context)
        {
            _context = context;
        }

        public void Add(Book item)
        {
            //sparar bok i databasen
            _context.Books.Add(item);
            _context.SaveChanges();
        }

        public void Remove(Book item)
        {
            //om boken har bokkopior får man inte ta bort den, justerar vi det här eller gör vi de i services?
            Book BookToRemove = _context.Books.Find(item.Id);
            if(BookToRemove != null)
                _context.Books.Remove(BookToRemove);
            _context.SaveChanges();
        }

        public Book Find(int bookId)
        {
            Book book = _context.Books.Find(bookId);
            return book;
        }
        public void Edit(Book newBookData)
        {
            //var bookToEdit = Find(newBookData.Id);
            Book bookToEdit = _context.Books.Find(newBookData.Id);

            bookToEdit.Title = newBookData.Title;
            bookToEdit.Author = newBookData.Author;
            bookToEdit.Description = newBookData.Description;
            bookToEdit.ISBN = newBookData.ISBN;

            _context.SaveChanges();
        }

        public IEnumerable<Book> All()
        {
            return _context.Books.ToList<Book>();
        }

    }
}