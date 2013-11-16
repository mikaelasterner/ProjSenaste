using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Models
{
    class BookCopy
    {
        public int Id { get; set; }
        public Book Book { get; set; }
        public override string ToString()
        {
            return Book.Title;
        }
    }
}
