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
        public void DeleteOrderDetail(int orderId, int productId) => OrderDetailDAO.Instance.RemoveOrderDetail(orderId, productId);

        public OrderDetail GetOrderDetail(int orderId, int productId) => OrderDetailDAO.Instance.GetOrderDetail(orderId, productId);

        public IEnumerable<OrderDetail> GetOrderDetailsByOrderId(int orderId) => OrderDetailDAO.Instance.GetOrderDetailsByOrderId(orderId);

        public IEnumerable<OrderDetail> GetOrdersDetails() => OrderDetailDAO.Instance.GetOrdersDetails();

        public void InsertOrderDetail(OrderDetail orderDetail) => OrderDetailDAO.Instance.InsertOrderDetail(orderDetail);

        public void UpdateOrderDetail(OrderDetail orderDetail) => OrderDetailDAO.Instance.UpdateOrderDetail(orderDetail);
    }
}
