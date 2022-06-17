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
        IEnumerable<Member> GetMemberList();
        Member GetMemberByID(int memberID);
        void AddMember(Member member);
        void UpdateMember(Member member);
        void DeleteMember(int memberID);
    }
}
