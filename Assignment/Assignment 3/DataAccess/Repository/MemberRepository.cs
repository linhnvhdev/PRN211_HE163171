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
        public void DeleteMember(int id) => MemberDAO.Instance.RemoveMember(id);

        public IEnumerable<Member> GetMembers() => MemberDAO.Instance.GetMembers();

        public Member GetMember(int id) => MemberDAO.Instance.GetMember(id);

        public void InsertMember(Member member) => MemberDAO.Instance.InsertMember(member);

        public void UpdateMember(Member member) => MemberDAO.Instance.UpdateMember(member);

        public Member GetMember(string email, string password) => MemberDAO.Instance.GetMember(email, password);
    }
}
