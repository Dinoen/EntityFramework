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

        public OrderDetails(int orderId, int productId, int unitPrice, int quantity, int discount, Product product)
        {
            OrderId = orderId;
            ProductId = productId;
            UnitPrice = unitPrice;
            Quantity = quantity;
            Discount = discount;
            Product = product;
        }


        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }


}