using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public interface IOrderDetailRepository
    {
        IEnumerable<OrderDetail> GetOrdersDetails();
        IEnumerable<OrderDetail> GetOrderDetailsByOrderId(int orderId);
        OrderDetail GetOrderDetail(int orderId, int productId);
        void InsertOrderDetail(OrderDetail orderDetail);
        void UpdateOrderDetail(OrderDetail orderDetail);
        void DeleteOrderDetail(int orderId, int productId);
    }
}
