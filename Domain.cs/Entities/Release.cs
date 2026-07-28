using Domain.cs.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.cs.Entities
{
    public class Release: AuditBase
    {
        public int BandId { get; set; }

        public string Title { get; set; } = string.Empty;

        public DateTime Year { get; set; } = DateTime.UtcNow; 

        public ReleaseType ReleaseType { get; set; }

        //relacion con band

        public Band Band { get; set; } = null!;

        
        public ICollection<Product> Products { get; set; } = new List<Product>();




        }
    }
