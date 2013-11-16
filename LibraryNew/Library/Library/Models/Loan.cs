using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Models
{
    class Loan
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public DateTime DueDate { get; set; } 
        public DateTime? ReturnTime { get; set; }
        public BookCopy Book_copy { get; set; }
        public Member Member { get; set; }
        public override string ToString()
        {
            string retstr = "#" + Id + ", " + Book_copy + " Loaned: " + Time.ToShortDateString() + ". Due: " +
                            DueDate.ToShortDateString() + ". By: " + Member;

            if (ReturnTime.HasValue)
                retstr += " Status: " + ReturnTime.Value.ToShortDateString();
            else retstr += " Status: unreturned";
            return retstr;
        }
    }
}
