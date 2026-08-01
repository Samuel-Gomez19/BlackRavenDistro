using Domain.cs.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.cs.Entities
{
    public class Order : AuditBase
    {
        

        public OrderStatus Status { get; set; }

        //navegation propierties

        public int CustomerId { get; set; }

        public Customer Customer { get; set; } = null!;

        public ICollection<OrderItem> Items { get; set; } = new List<OrderItem>();

   
    }
}
