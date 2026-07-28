using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Domain.cs.Enums;

namespace Domain.cs.Entities
{
    public class Product: AuditBase
    {
        public string Name { get; set; } = String.Empty;

        public Category Category { get; set; }

        public decimal Price {  get; set; }

        public string? Description { get; set; }
        //propiedades de navegacion
        public Band Band { get; set; } = null!;

        public int BandId { get; set; }

        public Release? Release { get; set; } = null!;

        public int? ReleaseId { get; set; }

        public ICollection<Stock> Stocks { get; set; } = new List<Stock>();

        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}


