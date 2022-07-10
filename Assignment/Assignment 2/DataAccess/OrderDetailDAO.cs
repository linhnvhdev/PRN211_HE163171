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
    public class OrderDetailDAO : BaseDAO
    {
        private static OrderDetailDAO instance = null;
        private static readonly object instanceLock = new object();
        private OrderDetailDAO() { }
        public static OrderDetailDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<OrderDetailObject> GetOrderDetail(int orderId)
        {
            IDataReader dataReader = null;
            string SQLSelect = "SELECT [OrderId]" +
                               "   ,[ProductId]" +
                               "   ,[UnitPrice]" +
                              "    ,[Quantity]" +
                              "    ,[Discount]" +
                              "FROM[dbo].[OrderDetail]";
            var orderdetails = new List<OrderDetailObject>();
            try
            {
                dataReader = DataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    orderdetails.Add(new OrderDetailObject
                    {
                        OrderId = dataReader.GetInt32(0),
                        ProductId = dataReader.GetInt32(1),
                        UnitPrice = dataReader.GetDecimal(2),
                        Quantity = dataReader.GetInt32(3),
                        Discount = dataReader.GetFloat(4)
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
            return orderdetails;
        }

        public OrderDetailObject GetOrderDetail(int orderId,int productId)
        {
            IDataReader dataReader = null;
            OrderDetailObject orderDetail = null;
            string SQLSelect = "SELECT [OrderId]" +
                               "   ,[ProductId]" +
                               "   ,[UnitPrice]" +
                              "    ,[Quantity]" +
                              "    ,[Discount]" +
                              "FROM[dbo].[OrderDetail] WHERE [OrderId] = @OrderId AND ProductId = @ProductId";
            try
            {
                var parameters = new List<SqlParameter>();
                parameters.Add(DataProvider.CreateParameter("@OrderId", 4, orderId, DbType.Int32));
                parameters.Add(DataProvider.CreateParameter("@ProductId", 4, productId, DbType.Int32));
                dataReader = DataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, parameters.ToArray());
                if (dataReader.Read())
                {
                    orderDetail = new OrderDetailObject
                    {
                        OrderId = dataReader.GetInt32(0),
                        ProductId = dataReader.GetInt32(1),
                        UnitPrice = dataReader.GetDecimal(2),
                        Quantity = dataReader.GetInt32(3),
                        Discount = dataReader.GetFloat(4)
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
            return orderDetail;
        }

        public void AddNew(OrderDetailObject orderDetail)
        {
            try
            {
                OrderDetailObject od = GetOrderDetail(orderDetail.OrderId, orderDetail.ProductId);
                if (od == null)
                {
                    string SQLInsert = "INSERT INTO [dbo].[OrderDetail]" +
                                       "        ([OrderId]" +
                                       "   ,[ProductId]" +
                                        "   ,[UnitPrice]" +
                                        "    ,[Quantity]" +
                                      "    ,[Discount]" +
                                       "  VALUES" +
                                       "        (@OrderId" +
                                       "        ,@ProductId" +
                                       "        ,@UnitPrice" +
                                       "        ,@Quantity" +
                                       "        ,@Discount)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(DataProvider.CreateParameter("@OrderId", 4, orderDetail.OrderId, DbType.Int32));
                    parameters.Add(DataProvider.CreateParameter("@ProductId", 4, orderDetail.ProductId, DbType.Int32));
                    parameters.Add(DataProvider.CreateParameter("@UnitPrice", 30, orderDetail.UnitPrice, DbType.Decimal));
                    parameters.Add(DataProvider.CreateParameter("@Quantity", 4, orderDetail.Quantity, DbType.Int32));
                    parameters.Add(DataProvider.CreateParameter("@Discount", 16, orderDetail.Discount, DbType.Double));
                    DataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The order detail is already exist");
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

        public void Update(OrderDetailObject orderDetail)
        {
            try
            {
                OrderDetailObject od = GetOrderDetail(orderDetail.OrderId,orderDetail.ProductId);
                if (od != null)
                {
                    string SQLUpdate = "Update OrderDetail set UnitPrice = @UnitPrice,"
                                      + "Quantity = @Quantity, Discount = @Discount"
                                      + " where OrderId = @OrderId AND ProductId = @ProductId";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(DataProvider.CreateParameter("@OrderId", 4, orderDetail.OrderId, DbType.Int32));
                    parameters.Add(DataProvider.CreateParameter("@ProductId", 4, orderDetail.ProductId, DbType.Int32));
                    parameters.Add(DataProvider.CreateParameter("@UnitPrice", 30, orderDetail.UnitPrice, DbType.Decimal));
                    parameters.Add(DataProvider.CreateParameter("@Quantity", 4, orderDetail.Quantity, DbType.Int32));
                    parameters.Add(DataProvider.CreateParameter("@Discount", 16, orderDetail.Discount, DbType.Double));
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

        public void Remove(int orderId,int productId)
        {
            try
            {
                OrderDetailObject od = GetOrderDetail(orderId,productId);
                if (od != null)
                {
                    string SQLDelete = "Delete OrderDetail where OrderId = @OrderId AND ProductId = @ProductId";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(DataProvider.CreateParameter("@OrderId", 4, orderId, DbType.Int32));
                    parameters.Add(DataProvider.CreateParameter("@ProductId", 4, productId, DbType.Int32));
                    DataProvider.Delete(SQLDelete, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The order detail does not already exist");
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
