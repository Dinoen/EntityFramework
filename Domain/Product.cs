using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;

namespace EntityFramework.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Categoryid {get; set;}

        public Category Category {get; set;}

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}