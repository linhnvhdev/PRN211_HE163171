using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess
{
    public class MemberDAO
    {

        private static List<Member> _memberList = 
            JsonSerializer.Deserialize<List<Member>>(File.ReadAllText("appsettings.json"));
        private static MemberDAO _instance = null;
        private static Object _instanceLock = new object();
        private MemberDAO() { }
        public static MemberDAO Instance
        {
            get
            {
                lock (_instanceLock)
                {
                    if(_instance == null)
                    {
                        _instance = new MemberDAO();
                    }
                    return _instance;                }
            }
        }

        public List<Member> GetMemberList => _memberList;
        public Member GetMemberByID(int memberID)
        {
            return _memberList.Find(x => x.MemberID == memberID);
        }

        public void AddMember(Member member)
        {
            if (member == null)
                return;
            if (_memberList.Exists(x => x.MemberID == member.MemberID))
            {
                throw new Exception("Member already exist");
            }
            else
            {
                _memberList.Add(member);
            }
        }

        public void UpdateMember(Member member)
        {
            Member existingMember = GetMemberByID(member.MemberID);
            if(existingMember == null)
            {
                throw new Exception("Member to update not exist");
            }
            else
            {
                var index = _memberList.IndexOf(existingMember);
                _memberList[index] = member;
            }
        }

        public void DeleteMember(int memberID)
        {
            Member existingMember = GetMemberByID(memberID);
            if (existingMember == null)
            {
                throw new Exception("Member to update not exist");
            }
            else
            {
                _memberList.Remove(existingMember);
            }
        }
    }
}
