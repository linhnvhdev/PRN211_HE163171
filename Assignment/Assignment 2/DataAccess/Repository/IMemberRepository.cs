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
        IEnumerable<MemberObject> GetAllMembers();
        MemberObject GetMember(int id);
        void DeleteMember(int id);
        void UpdateMember(MemberObject member);
        void InsertMember(MemberObject member);

        MemberObject GetMember(string email, string password);

    }
}
