using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using System.Data;
using Microsoft.Data.SqlClient;

namespace DataAccess
{
    public class OrderDAO : BaseDAO
    {
        private static OrderDAO instance = null;
        private static readonly object instanceLock = new object();
        private OrderDAO() { }
        public static OrderDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<OrderObject> GetOrderList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "SELECT [OrderId]" +
                               "   ,[MemberId]" +
                               "   ,[OrderDate]" +
                              "    ,[RequiredDate]" +
                              "    ,[ShippedDate]" +
                              "    ,[Freight]" +
                              "FROM[dbo].[Order]";
            var orders = new List<OrderObject>();
            try
            {
                dataReader = DataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    orders.Add(new OrderObject
                    {
                        Id = dataReader.GetInt32(0),
                        MemberId = dataReader.GetInt32(1),
                        OrderDate = dataReader.GetDateTime(2),
                        RequiredDate = dataReader.GetDateTime(3),
                        ShippedDate = dataReader.GetDateTime(4),
                        Freight = dataReader.GetDecimal(5)
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
            return orders;
        }

        public OrderObject GetOrderByID(int orderId)
        {
            IDataReader dataReader = null;
            OrderObject order = null;
            string SQLSelect = "SELECT [OrderId]" +
                               "   ,[MemberId]" +
                               "   ,[OrderDate]" +
                              "    ,[RequiredDate]" +
                              "    ,[ShippedDate]" +
                              "    ,[Freight]" +
                              "FROM[dbo].[Order] WHERE [OrderId] = @OrderId";
            try
            {
                var param = DataProvider.CreateParameter("@OrderId", 4, orderId, DbType.Int32);
                dataReader = DataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    order = new OrderObject
                    {
                        Id = dataReader.GetInt32(0),
                        MemberId = dataReader.GetInt32(1),
                        OrderDate = dataReader.GetDateTime(2),
                        RequiredDate = dataReader.GetDateTime(3),
                        ShippedDate = dataReader.GetDateTime(4),
                        Freight = dataReader.GetDecimal(5)
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
            return order;
        }

        public void AddNew(OrderObject order)
        {
            try
            {
                OrderObject o = GetOrderByID(order.Id);
                if (o == null)
                {
                    string SQLInsert = "INSERT INTO [dbo].[Order]" +
                                       "        ([OrderId]" +
                                       "   ,[MemberId]" +
                                        "   ,[OrderDate]" +
                                        "    ,[RequiredDate]" +
                                      "    ,[ShippedDate]" +
                                      "    ,[Freight]" +
                                       "  VALUES" +
                                       "        (@OrderId" +
                                       "        ,@MemberId" +
                                       "        ,@OrderDate" +
                                       "        ,@RequiredDate" +
                                       "        ,@ShippedDate" +
                                       "        ,@Freight)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(DataProvider.CreateParameter("@OrderId", 4, order.Id, DbType.Int32));
                    parameters.Add(DataProvider.CreateParameter("@MemberId", 4, order.MemberId, DbType.Int32));
                    parameters.Add(DataProvider.CreateParameter("@OrderDate", 8, order.OrderDate, DbType.DateTime));
                    parameters.Add(DataProvider.CreateParameter("@RequiredDate", 8, order.RequiredDate, DbType.DateTime));
                    parameters.Add(DataProvider.CreateParameter("@ShippedDate", 8, order.ShippedDate, DbType.DateTime));
                    parameters.Add(DataProvider.CreateParameter("@Freight", 50, order.Freight, DbType.Decimal));
                    DataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The order is already exist");
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

        public void Update(OrderObject order)
        {
            try
            {
                OrderObject o = GetOrderByID(order.Id);
                if (o != null)
                {
                    string SQLUpdate = "Update order set Freight = @Freight,"
                                      + "MemberId = @MemberId, OrderDate = @OrderDate, RequiredDate = @RequiredDate, ShippedDate = @ShippedDate"
                                      + "where OrderId = @OrderId";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(DataProvider.CreateParameter("@OrderId", 4, order.Id, DbType.Int32));
                    parameters.Add(DataProvider.CreateParameter("@MemberId", 4, order.MemberId, DbType.Int32));
                    parameters.Add(DataProvider.CreateParameter("@OrderDate", 8, order.OrderDate, DbType.DateTime));
                    parameters.Add(DataProvider.CreateParameter("@RequiredDate", 8, order.RequiredDate, DbType.DateTime));
                    parameters.Add(DataProvider.CreateParameter("@ShippedDate", 8, order.ShippedDate, DbType.DateTime));
                    parameters.Add(DataProvider.CreateParameter("@Freight", 50, order.Freight, DbType.Decimal));
                    DataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The order does not already exist");
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

        public void Remove(int orderId)
        {
            try
            {
                OrderObject o = GetOrderByID(orderId);
                if (o != null)
                {
                    string SQLDelete = "Delete Order where OrderId = @OrderId";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(DataProvider.CreateParameter("@OrderId", 4, orderId, DbType.Int32));
                    DataProvider.Delete(SQLDelete, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The order does not already exist");
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
