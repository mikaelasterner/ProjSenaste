﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Models
{
    class Book
    {
        public int Id { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }
        public string Description { get; set; }
        //public int? Copies { get; set; }
    }
}
