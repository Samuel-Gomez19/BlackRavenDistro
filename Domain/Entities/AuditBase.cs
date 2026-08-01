using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.cs.Entities
{
    public class AuditBase
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }


    }
}
