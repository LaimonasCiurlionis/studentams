using Project.Common.DTOs;
using Project.Repositories.Models;
using System.Collections.Generic;
using System.Linq;

namespace Project.Repositories
{
    public class OrderItemRepository
    {
        private List<OrderItem> OrderItems { get; set; }

        public OrderItemRepository()
        {
            OrderItems = new List<OrderItem>();
        }

        public List<OrderItem> Get() => OrderItems;
        public OrderItem Get(int id) => OrderItems.Single(x => x.Id == id);
        public OrderItem Add(OrderItemModel orderItem, int orderId) 
        {
            if (orderItem != null) 
            {
                var entity = new OrderItem();
                entity.Id = OrderItems.Count() + 1;
                entity.Name = orderItem.Name;
                entity.OrderId = orderId;
                entity.Quantity = orderItem.Quantity;

                OrderItems.Add(entity);

                return entity;
            }

            return null;
        }
    }
}
