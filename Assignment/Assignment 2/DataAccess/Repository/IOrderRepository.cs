using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        IEnumerable<OrderObject> GetAllOrders();
        IEnumerable<OrderObject> GetOrdersByMemberId(int memberId);

        void AddOrder(OrderObject orderObject);
        void UpdateOrder(OrderObject orderObject);
        void DeleteOrder(int orderId);
        OrderObject GetOrderById(int orderId);

    }
}
