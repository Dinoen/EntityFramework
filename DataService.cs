using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityFramework.Domain;

namespace EntityFramework
{
    public interface iDataService
    {
        IList<Category> GetCategories();
        bool CreateCategory(Category category);
        IList<Product> GetProducts();
    }
    public class DataService : iDataService
    {
        public bool CreateCategory(Category category)
        {
            var ctx = new NorthwindContext();
            category.Id = ctx.categories.Max(x => x.Id) + 1;
            ctx.Add(category);
            return ctx.SaveChanges() > 0;
        }

        public IList<Category> GetCategories()
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetProducts()
        {
            throw new NotImplementedException();
        }


    }
}