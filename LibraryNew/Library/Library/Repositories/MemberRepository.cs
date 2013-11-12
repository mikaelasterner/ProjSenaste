using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Models;

namespace Library.Repositories
{
    class MemberRepository : IRepository<Member, int>
    {
        LibraryContext _context;

        public MemberRepository(LibraryContext context)
        {
            _context = context;
        }

        public void Add(Member member)
        {
            //sparar bok i databasen
            _context.Members.Add(member);
            _context.SaveChanges();
        }

        public void Remove(Member member)
        {
            //kontrollera så inte medlemmen har lån innan den tas bort
            Member MemberToRemove = _context.Members.Find(member.Id);
            if (MemberToRemove != null)
                _context.Members.Remove(MemberToRemove);
            _context.SaveChanges();
        }

        public Member Find(int id)
        {
            Member MemberToReturn = _context.Members.Find(id);
            return MemberToReturn;
        }

        public void Edit(Member item)
        {
            Member MemberToEdit = _context.Members.Find(item.Id);
            MemberToEdit.Name = item.Name;
            MemberToEdit.PrId = item.PrId;
            if (item.Loans != null)
                MemberToEdit.Loans = item.Loans;
            _context.SaveChanges();
        }

        public IEnumerable<Member> All()
        {
            return _context.Members.ToList<Member>();
        }
    }
}