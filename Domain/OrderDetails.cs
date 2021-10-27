using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace EntityFramework.Domain
{
    public class OrderDetails
    {


        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int Discount { get; set; }
        public Product Product { get; set; }

        public OrderDetails()
        {
           
        }


        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }


}