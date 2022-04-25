using System.Collections.Generic;

namespace Project.Common.DTOs
{
    public class OrderModel
    {
        public decimal TotalPrice { get; set; }
        public List<OrderItemModel> Items { get; set; }
    }
}
