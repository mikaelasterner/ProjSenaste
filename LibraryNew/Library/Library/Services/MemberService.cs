using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Repositories;
using Library.Models;

namespace Library.Services
{
    class MemberService : IService<Member>
    {
        readonly IRepository<Member, int> _memberRepository;
        //för att komma åt add metoden i repository skapas en instans av repository


        public MemberService(IRepository<Member, int> repository)
        {
            _memberRepository = repository;
        }

        public void Add(Member member)
        {
            _memberRepository.Add(member);
            //utlös eventet för att lägga till en bok
            OnUpdate(new ServiceEventArgs<Member>(Operation.Add, member, _memberRepository.All().Count()));
        }

        public void Remove(Member member)
        {
            _memberRepository.Remove(member);
            //utlös eventet för att lägga till en bok
            OnUpdate(new ServiceEventArgs<Member>(Operation.Remove, member, _memberRepository.All().Count()));
        }

        public ICollection<Loan> GetLoansForMember(Member member)
        {
            var mem =_memberRepository.Find(member.Id);
            if (mem != null)
                return mem.Loans;
            return null;
        }

        public IEnumerable<Member> All()
        {
            return _memberRepository.All();
        }


        public event EventHandler<ServiceEventArgs<Member>> Updated;

        protected virtual void OnUpdate(ServiceEventArgs<Member> ea)
        {
            if (Updated != null)
            {
                Updated(this, ea);
            }
        }
    }
}