using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityFramework.Domain;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework
{
    public interface iDataService
    {
        IList<Category> GetCategories();
        Category GetCategory(int id);
        Category CreateCategory(string name, string description);
        bool DeleteCategory(int id);
        bool UpdateCategory(int id, string name, string description);

        IList<Product> GetProducts();
        Product GetProduct(int id);
        // IList<Order> GetOrders();

        // Product GetProduct(int id);
    }
    public class DataService : iDataService
    {
        public Category CreateCategory(string name, string description)
        {
            var ctx = new NorthwindContext();
            var cat = new Category { Id = ctx.categories.Max(x => x.Id) + 1, Name = name, Description = description };
            ctx.Add(cat);
            ctx.SaveChanges();
            return cat;
        }

        public bool DeleteCategory(int id)
        {
            var ctx = new NorthwindContext();

            var cat = ctx.categories.Find(id);

            if (cat != null)
            {
                ctx.categories.Remove(cat);
                return ctx.SaveChanges() > 0;
            }
            else return false;
        }

        public IList<Category> GetCategories()
        {
            var ctx = new NorthwindContext();
            return ctx.categories.ToList();
        }

        public Category GetCategory(int id)
        {
            var ctx = new NorthwindContext();
            return ctx.categories.Find(id);

        }

        public Product GetProduct(int id)
        {
            var ctx = new NorthwindContext();
            Console.WriteLine(ctx.products.Include(x => x.Category).FirstOrDefault(x => x.Id == id));
            return ctx.products.Include(x => x.Category).FirstOrDefault(x => x.Id == id);
        }

        public IList<Product> GetProducts()
        {
            var ctx = new NorthwindContext();
            var products = ctx.products;

            return products.ToList();
        }

        public bool UpdateCategory(int id, string name, string description)
        {
            var ctx = new NorthwindContext();
            var cat = ctx.categories.Find(id);

            if (cat != null)
            {
                cat.Id = id;
                cat.Name = name;
                cat.Description = description;
                return ctx.SaveChanges() > 0;
            }
            else return false;
        }
    }
}