using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess
{
    public class OrderDetailDAO
    {
        private static OrderDetailDAO instance = null;
        private static readonly object instanceLock = new object();
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

        public IEnumerable<OrderDetail> GetOrdersDetails()
        {
            var orderDetails = new List<OrderDetail>();
            try
            {
                using var context = new FStoreContext();
                orderDetails = context.OrderDetails.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orderDetails;
        }

        public IEnumerable<OrderDetail> GetOrderDetailsByOrderId(int orderId)
        {
            var orderDetails = new List<OrderDetail>();
            try
            {
                using var context = new FStoreContext();
                orderDetails = context.OrderDetails.Where(x => x.OrderId == orderId).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orderDetails;
        }

        public OrderDetail GetOrderDetail(int orderId,int productId)
        {
            OrderDetail orderDetail = null;
            try
            {
                using var context = new FStoreContext();
                orderDetail = context.OrderDetails.SingleOrDefault(
                        m => m.OrderId == orderId && m.ProductId == productId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orderDetail;
        }

        public void InsertOrderDetail(OrderDetail orderDetail)
        {
            try
            {
                OrderDetail od = GetOrderDetail(orderDetail.OrderId, orderDetail.ProductId);
                if (od == null)
                {
                    using var context = new FStoreContext();
                    context.OrderDetails.Add(orderDetail);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Order details exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateOrderDetail(OrderDetail orderDetail)
        {
            try
            {
                OrderDetail od = GetOrderDetail(orderDetail.OrderId, orderDetail.ProductId);
                if (od != null)
                {
                    using var context = new FStoreContext();
                    context.OrderDetails.Update(orderDetail);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Order details not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RemoveOrderDetail(int orderId,int productId)
        {
            try
            {
                OrderDetail orderDetail = GetOrderDetail(orderId, productId);
                if (orderDetail != null)
                {
                    using var context = new FStoreContext();
                    context.OrderDetails.Remove(orderDetail);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Order details not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
