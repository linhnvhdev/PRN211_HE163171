using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System.IO;

namespace DataAccess
{
    public class MemberDAO : BaseDAO
    {
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();

        private MemberObject GetAdminAccount()
        {
            IConfiguration config = new ConfigurationBuilder()
                                    .SetBasePath(Directory.GetCurrentDirectory())
                                    .AddJsonFile("appsettings.json", true, true)
                                    .Build();
            return new MemberObject
            {
                Id = int.Parse(config["AdminAccount:MemberId"]),
                Email = config["AdminAccount:Email"],
                CompanyName = config["AdminAccount:CompanyName"],
                City = config["AdminAccount:City"],
                Country = config["AdminAccount:Country"],
                Password = config["AdminAccount:Password"]
            };
        }

        private MemberDAO() {
            MemberObject adminAccount = GetAdminAccount();
            if(GetMemberByID(adminAccount.Id) == null)
            {
                AddNew(adminAccount);
            }
        }
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<MemberObject> GetMemberList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "SELECT [MemberId]"+
                               "   ,[Email]"+
                               "   ,[CompanyName]"+
                              "    ,[City]"+
                              "    ,[Country]"+
                              "    ,[Password]"+
                              "FROM[dbo].[Member]";
            var members = new List<MemberObject>();
            try
            {
                dataReader = DataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    members.Add(new MemberObject
                    {
                        Id = dataReader.GetInt32(0),
                        Email = dataReader.GetString(1),
                        CompanyName = dataReader.GetString(2),
                        City = dataReader.GetString(3),
                        Country = dataReader.GetString(4),
                        Password = dataReader.GetString(5)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return members;
        }

        public MemberObject GetMemberByID(int memberId)
        {
            IDataReader dataReader = null;
            MemberObject member = null;
            string SQLSelect = "SELECT [MemberId]" +
                               "   ,[Email]" +
                               "   ,[CompanyName]" +
                              "    ,[City]" +
                              "    ,[Country]" +
                              "    ,[Password]" +
                              "FROM[dbo].[Member] WHERE [MemberId] = @MemberId";
            try
            {
                var param = DataProvider.CreateParameter("@MemberId", 4, memberId, DbType.Int32);
                dataReader = DataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    member = new MemberObject
                    {
                        Id = dataReader.GetInt32(0),
                        Email = dataReader.GetString(1),
                        CompanyName = dataReader.GetString(2),
                        City = dataReader.GetString(3),
                        Country = dataReader.GetString(4),
                        Password = dataReader.GetString(5)
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return member;
        }

        public MemberObject GetMember(string email,string password)
        {
            IDataReader dataReader = null;
            MemberObject member = null;
            string SQLSelect = "SELECT [MemberId]" +
                               "   ,[Email]" +
                               "   ,[CompanyName]" +
                              "    ,[City]" +
                              "    ,[Country]" +
                              "    ,[Password]" +
                              "FROM[dbo].[Member] WHERE [Email] = @Email AND [Password] = @Password";
            try
            {
                var parameters = new List<SqlParameter>();
                parameters.Add(DataProvider.CreateParameter("@Email", 100, email, DbType.String));
                parameters.Add(DataProvider.CreateParameter("@Password", 30, password, DbType.String));
                dataReader = DataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, parameters.ToArray());
                if (dataReader.Read())
                {
                    member = new MemberObject
                    {
                        Id = dataReader.GetInt32(0),
                        Email = dataReader.GetString(1),
                        CompanyName = dataReader.GetString(2),
                        City = dataReader.GetString(3),
                        Country = dataReader.GetString(4),
                        Password = dataReader.GetString(5)
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return member;
        }

        public void AddNew(MemberObject member)
        {
            try
            {
                MemberObject mem = GetMemberByID(member.Id);
                if (mem == null)
                {
                    string SQLInsert = "INSERT INTO [dbo].[Member]"+
                                       "        ([MemberId]" +
                                       "        ,[Email]" +
                                       "        ,[CompanyName]" +
                                       "        ,[City]" +
                                       "        ,[Country]" +
                                       "        ,[Password])" +
                                       "  VALUES" +
                                       "        (@MemberId" +
                                       "        ,@Email" +
                                       "        ,@CompanyName" +
                                       "        ,@City" +
                                       "        ,@Country" +
                                       "        ,@Password)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(DataProvider.CreateParameter("@MemberId", 4, member.Id, DbType.Int32));
                    parameters.Add(DataProvider.CreateParameter("@Email", 100, member.Email, DbType.String));
                    parameters.Add(DataProvider.CreateParameter("@CompanyName", 40, member.CompanyName, DbType.String));
                    parameters.Add(DataProvider.CreateParameter("@City", 15, member.City, DbType.String));
                    parameters.Add(DataProvider.CreateParameter("@Country", 15, member.Country, DbType.String));
                    parameters.Add(DataProvider.CreateParameter("@Password", 30, member.Password, DbType.String));
                    DataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The member is already exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Update(MemberObject member)
        {
            try
            {
                MemberObject mem = GetMemberByID(member.Id);
                if (mem != null)
                {
                    string SQLUpdate = "Update Member set Email = @Email,"
                                      + "CompanyName = @CompanyName, City = @City, Country = @Country, Password = @Password"
                                      + "where MemberId = @MemberId";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(DataProvider.CreateParameter("@MemberId", 4, member.Id, DbType.Int32));
                    parameters.Add(DataProvider.CreateParameter("@Email", 100, member.Email, DbType.String));
                    parameters.Add(DataProvider.CreateParameter("@CompanyName", 40, member.CompanyName, DbType.String));
                    parameters.Add(DataProvider.CreateParameter("@City", 15, member.City, DbType.String));
                    parameters.Add(DataProvider.CreateParameter("@Country", 15, member.Country, DbType.String));
                    parameters.Add(DataProvider.CreateParameter("@Password", 30, member.Password, DbType.String));
                    DataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The member does not already exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }

        }

        public void Remove(int memberId)
        {
            try
            {
                MemberObject mem = GetMemberByID(memberId);
                if (mem != null)
                {
                    string SQLDelete = "Delete Member where MemberId = @MemberId";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(DataProvider.CreateParameter("@MemberId", 4, memberId, DbType.Int32));
                    DataProvider.Delete(SQLDelete, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The member does not already exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }

        }
    }
}
