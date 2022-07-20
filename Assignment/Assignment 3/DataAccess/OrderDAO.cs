using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess
{
    public class OrderDAO
    {
        private static OrderDAO instance = null;
        private static readonly object instanceLock = new object();
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

        public IEnumerable<Order> GetOrders()
        {
            var Orders = new List<Order>();
            try
            {
                using var context = new FStoreContext();
                Orders = context.Orders.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Orders;
        }

        public IEnumerable<Order> GetOrders(int memberId)
        {
            var Orders = new List<Order>();
            try
            {
                using var context = new FStoreContext();
                Orders = context.Orders.Where(x => x.MemberId == memberId).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Orders;
        }

        public Order GetOrder(int id)
        {
            Order order = null;
            try
            {
                using var context = new FStoreContext();
                order = context.Orders.SingleOrDefault(m => m.OrderId == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return order;
        }

        public void InsertOrder(Order order)
        {
            try
            {
                Order o = GetOrder(order.OrderId);
                if (o == null)
                {
                    using var context = new FStoreContext();
                    context.Orders.Add(order);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Order exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateOrder(Order order)
        {
            try
            {
                Order o = GetOrder(order.OrderId);
                if (o != null)
                {
                    using var context = new FStoreContext();
                    context.Orders.Update(order);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Order not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RemoveOrder(int id)
        {
            try
            {
                Order order = GetOrder(id);
                if (order != null)
                {
                    using var context = new FStoreContext();
                    context.Orders.Remove(order);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Order not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
