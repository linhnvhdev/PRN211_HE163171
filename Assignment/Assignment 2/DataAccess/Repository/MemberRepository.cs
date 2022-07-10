using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public void DeleteMember(int id) => MemberDAO.Instance.Remove(id);

        public IEnumerable<MemberObject> GetAllMembers() => MemberDAO.Instance.GetMemberList();

        public MemberObject GetMember(int id) => MemberDAO.Instance.GetMemberByID(id);

        public MemberObject GetMember(string email, string password) => MemberDAO.Instance.GetMember(email, password);

        public void InsertMember(MemberObject member) => MemberDAO.Instance.AddNew(member);

        public void UpdateMember(MemberObject member) => MemberDAO.Instance.Update(member);
        
    }
}
