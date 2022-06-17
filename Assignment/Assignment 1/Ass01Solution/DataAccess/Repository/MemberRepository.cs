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
        public void AddMember(Member member) => MemberDAO.Instance.AddMember(member);

        public void DeleteMember(int memberID) => MemberDAO.Instance.DeleteMember(memberID);

        public Member GetMemberByID(int memberID) => MemberDAO.Instance.GetMemberByID(memberID);

        public IEnumerable<Member> GetMemberList() => MemberDAO.Instance.GetMemberList;

        public void UpdateMember(Member member) => MemberDAO.Instance.UpdateMember(member);
    }
}
