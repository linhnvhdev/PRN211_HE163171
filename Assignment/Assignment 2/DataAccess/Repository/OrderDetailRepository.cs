using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public void AddOrderDetail(OrderDetailObject orderDetail) => OrderDetailDAO.Instance.AddNew(orderDetail);

        public void DeleteOrderDetail(int orderId, int productId) => OrderDetailDAO.Instance.Remove(orderId, productId);

        public OrderDetailObject GetOrderDetail(int orderId, int productId) => OrderDetailDAO.Instance.GetOrderDetail(orderId, productId);

        public IEnumerable<OrderDetailObject> GetOrderDetails(int orderId) => OrderDetailDAO.Instance.GetOrderDetail(orderId);

        public void UpdateOrderDetail(OrderDetailObject orderDetail) => OrderDetailDAO.Instance.Update(orderDetail);
    }
}
