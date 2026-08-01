using Domain.cs.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.cs.Entities
{
    public class Country:AuditBase
    { 
        public string CountryName { get; set; } = string.Empty;

        public string Code { get; set; } = string.Empty;

        public TypeCurrency Currency {get ; set; }
        //n.p
        public ICollection<Customer> Customer  { get; set; } = new List<Customer>();

    }
}
