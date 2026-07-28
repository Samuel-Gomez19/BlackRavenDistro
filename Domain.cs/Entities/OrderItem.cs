using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.cs.Entities
{
    public class OrderItem:AuditBase
    {
        public int OrderId { get; set; }

        public Order Order { get; set; } = null!;

        public int ProductId { get; set; }

        public Product Product { get; set; } = null!;


        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }





    }
}
