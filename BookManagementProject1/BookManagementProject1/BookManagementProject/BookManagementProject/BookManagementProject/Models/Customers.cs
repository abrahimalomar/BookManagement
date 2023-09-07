using System;
using System.Collections.Generic;
using System.Text;

namespace BookManagementProject.Models
{
    public class Customers
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }

        public ICollection<CustomersBooks> customersBooks { get; set; }
    }
}
