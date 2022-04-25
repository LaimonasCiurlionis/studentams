using Project.Common;
using Project.Common.DTOs;
using Project.Repositories;
using System;

namespace Project.BusinessLogic
{
    public class OrderService
    {
        private readonly OrderRepository _orderRepository;
        private readonly OrderItemRepository _orderItemRepository;

        public OrderService(OrderRepository orderRepository, OrderItemRepository orderItemRepository)
        {
            _orderRepository = orderRepository;
            _orderItemRepository = orderItemRepository;
        }

        public void SubmitOrder(OrderModel model) 
        {
            if (Validator.IsTotalPrice(model.TotalPrice) && Validator.IsQuantity(model.Items)) 
            {
                Console.WriteLine("Wrong input");
                return;
            }

            var orderEntity = _orderRepository.Add(model);

            foreach (var orderItem in model.Items)
            {
                var orderItemEntity  = _orderItemRepository.Add(orderItem, orderEntity.Id);
            }
        }
    }
}
