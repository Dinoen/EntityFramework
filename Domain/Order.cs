using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace EntityFramework.Domain
{
    public class Order
    {


        public int OrderId { get; set; }
        public string CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime Orderdate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public int Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }
        public OrderDetails[] OrderDetails { get; set; }

        public Order(int orderId, string customerId, int employeeId, DateTime orderdate, DateTime requiredDate, DateTime shippedDate, int freight, string shipName, string shipAddress, string shipCity, string shipPostalCode, string shipCountry, OrderDetails[] orderDetails)
        {
            OrderId = orderId;
            CustomerId = customerId;
            EmployeeId = employeeId;
            Orderdate = orderdate;
            RequiredDate = requiredDate;
            ShippedDate = shippedDate;
            Freight = freight;
            ShipName = shipName;
            ShipAddress = shipAddress;
            ShipCity = shipCity;
            ShipPostalCode = shipPostalCode;
            ShipCountry = shipCountry;
            OrderDetails = orderDetails;
        }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}