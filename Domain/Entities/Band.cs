using Domain.cs.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.cs.Entities
{
    public class Band: AuditBase
    {
        public string BandName { get; set; } = string.Empty;

        public string? Description { get; set; }

        public Genre Genre { get; set; }
        //propiedades de navegacion
        public ICollection<Release> Releases { get; set; } = new List<Release>();
        public ICollection<Product> Products { get; set; } = new List<Product>();



    }
}

