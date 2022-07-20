using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public void DeleteOrder(int id) => OrderDAO.Instance.RemoveOrder(id);

        public Order GetOrder(int id) => OrderDAO.Instance.GetOrder(id);

        public IEnumerable<Order> GetOrders() => OrderDAO.Instance.GetOrders();

        public IEnumerable<Order> GetOrders(int memberId) => OrderDAO.Instance.GetOrders(memberId);

        public void InsertOrder(Order order) => OrderDAO.Instance.InsertOrder(order);

        public void UpdateOrder(Order order) => OrderDAO.Instance.UpdateOrder(order);
    }
}
