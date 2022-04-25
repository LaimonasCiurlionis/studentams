using System;
using System.Collections.Generic;

namespace Project.Repositories.Models
{
    public class Order
    {
        public int Id { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime Created { get; set; }
    }
}
