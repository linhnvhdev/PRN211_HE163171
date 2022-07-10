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
        public void AddOrder(OrderObject orderObject) => OrderDAO.Instance.AddNew(orderObject);

        public void DeleteOrder(int orderId) => OrderDAO.Instance.Remove(orderId);

        public IEnumerable<OrderObject> GetAllOrders() => OrderDAO.Instance.GetOrderList();

        public OrderObject GetOrderById(int orderId) => OrderDAO.Instance.GetOrderByID(orderId);

        public IEnumerable<OrderObject> GetOrdersByMemberId(int memberId) => OrderDAO.Instance.GetOrderList();

        public void UpdateOrder(OrderObject orderObject) => OrderDAO.Instance.Update(orderObject);
    }
}
