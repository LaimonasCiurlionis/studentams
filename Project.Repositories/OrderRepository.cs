using Project.Common.DTOs;
using Project.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project.Repositories
{
    public class OrderRepository
    {
        public List<Order> Orders { get; set; }

        public OrderRepository()
        {
            Orders = new List<Order>();
        }

        public List<Order> Get() => Orders;
        public Order Get(int id) => Orders.Single(x => x.Id == id);
        public Order Add(OrderModel order)
        {
            if (order != null)
            {
                var entity = new Order();

                entity.Id = Orders.Count() + 1;
                entity.TotalPrice = order.TotalPrice;
                entity.Created = DateTime.Now;

                Orders.Add(entity);

                return entity;
            }

            return null;
        }
    }
}
