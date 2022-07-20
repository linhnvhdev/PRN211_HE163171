using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace DataAccess
{
    public class MemberDAO
    {
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();

        private Member GetAdminAccount()
        {
            IConfiguration config = new ConfigurationBuilder()
                                    .SetBasePath(Directory.GetCurrentDirectory())
                                    .AddJsonFile("appsettings.json", true, true)
                                    .Build();
            return new Member
            {
                Email = config["AdminAccount:Email"],
                CompanyName = config["AdminAccount:CompanyName"],
                City = config["AdminAccount:City"],
                Country = config["AdminAccount:Country"],
                Password = config["AdminAccount:Password"]
            };
        }

        private MemberDAO()
        {
            Member adminAccount = GetAdminAccount();
            if (GetMember(adminAccount.Email,adminAccount.Password) == null)
            {
                InsertMember(adminAccount);
            }
        }
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if(instance == null)
                    {
                        instance = new MemberDAO();

                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Member> GetMembers()
        {
            var members = new List<Member>();
            try
            {
                using var context = new FStoreContext();
                members = context.Members.ToList();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return members;
        }

        public Member GetMember(int id)
        {
            Member member = null;
            try
            {
                using var context = new FStoreContext();
                member = context.Members.SingleOrDefault(m => m.MemberId == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return member;
        }

        public Member GetMember(string email)
        {
            Member member = null;
            try
            {
                using var context = new FStoreContext();
                member = context.Members.SingleOrDefault(m => m.Email == email);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return member;
        }

        public Member GetMember(string email,string password)
        {
            Member member = null;
            try
            {
                using var context = new FStoreContext();
                member = context.Members.SingleOrDefault(m => m.Email == email && m.Password == password);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return member;
        }

        public void InsertMember(Member member)
        {
            try
            {
                Member m = GetMember(member.MemberId);
                Member m2 = GetMember(member.Email);
                if (m == null && m2 == null)
                {
                    using var context = new FStoreContext();
                    context.Members.Add(member);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("member exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateMember(Member member)
        {
            try
            {
                Member m = GetMember(member.MemberId);
                if (m != null)
                {
                    using var context = new FStoreContext();
                    context.Members.Update(member);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("member not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RemoveMember(int id)
        {
            try
            {
                Member m = GetMember(id);
                if (m != null)
                {
                    using var context = new FStoreContext();
                    context.Members.Remove(m);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("member not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
