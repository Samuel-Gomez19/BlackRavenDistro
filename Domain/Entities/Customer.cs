using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.cs.Entities
{
    public class Customer:AuditBase

    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Cellphone { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;
        //n.p
        public ICollection<Order> Orders { get; set; } = new List<Order>();

        public int CountryId { get; set; }

        public Country Country { get; set; } = null!;


        



    }
}
//relacion con order, country, products