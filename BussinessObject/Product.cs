using System;
using System.Collections.Generic;

#nullable disable

namespace BussinessObject
{
    public partial class Product
    {
        public Product()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal? WholesalePrice { get; set; }
        public decimal? RetailPrice { get; set; }
        public int? SupplierId { get; set; }

        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
