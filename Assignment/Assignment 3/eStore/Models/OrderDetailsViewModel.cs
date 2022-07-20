using BusinessObject;
using System;
using System.Collections.Generic;

namespace eStore.Models
{
    public class OrderDetailsViewModel
    {
        public Order Order { get; set; }
        public IEnumerable<OrderDetail> OrderDetails { get; set; }
    }
}
