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
        IEnumerable<Order> GetOrders();
        IEnumerable<Order> GetOrders(int memberId);
        public Order GetOrder(int id);
        public void InsertOrder(Order order);
        public void UpdateOrder(Order order);
        public void DeleteOrder(int id);
    }
}
