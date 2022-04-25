using Project.BusinessLogic;
using Project.Common.DTOs;
using Project.Repositories;
using System;
using System.Collections.Generic;

namespace Clases_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderService = new OrderService(new OrderRepository(), new OrderItemRepository());

            Console.WriteLine("Hello, please let me process your order");
            var orderModel = new OrderModel
            {
                TotalPrice = 92.61m,
                Items = new List<OrderItemModel>
                {
                    new OrderItemModel
                    {
                         Name = "Product1",
                         Quantity = 1
                    },
                    new OrderItemModel
                    {
                         Name = "Product2",
                         Quantity = 12
                    }

                }
            };

            orderService.SubmitOrder(orderModel);
        }
    }
}
