using System;
using System.Collections.Generic;

#nullable disable

namespace BussinessObject
{
    public partial class Order
    {
        public int Id { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? ProductId { get; set; }
        public int? CustomerId { get; set; }
        public int? Quantity { get; set; }
        public decimal? Unitprice { get; set; }
        public decimal? TotalAmount { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}
