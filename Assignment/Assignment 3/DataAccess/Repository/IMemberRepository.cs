using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<Member> GetMembers();
        Member GetMember(int id);

        Member GetMember(string email, string password);
        void InsertMember(Member member);
        void UpdateMember(Member member);
        void DeleteMember(int id);
    }
}
