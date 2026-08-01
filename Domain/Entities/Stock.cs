using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.cs.Entities
{
    public class Stock:AuditBase
    {
        public string? Color { get; set; } 

        public string? Size { get; set; }

        public int ReorderLevel { get; set; }

        public int Quantity { get; set; }



        public DateTime LastRestockDate { get; set; }

        //Navegation Propierties
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;

    }
}
