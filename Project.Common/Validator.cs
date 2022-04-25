using Project.Common.DTOs;
using System.Collections.Generic;

namespace Project.Common
{
    public static class Validator
    {
        public static bool IsQuantity(List<OrderItemModel> orderItems) 
        {
            return orderItems.TrueForAll(x => x.Quantity > 0);
        }

        public static bool IsTotalPrice(decimal price) 
        {
            return price > 0;
        }
    }
}
