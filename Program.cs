using System;
using EntityFramework.Domain;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            var ctx = new NorthwindContext();
            var categories = ctx.categories;

            foreach (var cat in categories)
            {
                System.Console.WriteLine(cat.ToString());
            }

            var c = new Category
            {
                Id = 101,
                Name = "Boardgames",
                Description = "Best ones ever"
            };

            //ctx.categories.Add(c);

            //ctx.categories.Remove(ctx.categories.Find(101));

            //ctx.SaveChanges();
        }
    }
}
