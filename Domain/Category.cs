using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace EntityFramework.Domain
{
    public class Category
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Category(int id, string name, string description)
        {
            this.Id = id;
            this.Description = description;
            this.Name = name;

        }

        public Category()
        {
        }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }


    }
}