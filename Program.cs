using System;
using EntityFramework.Domain;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataSvc = new DataService();
            // dataSvc.CreateCategory(new Category { Id = 10, Name = "Boardgames2", Description = "Gloomhaven2" });

            // var products = ctx.products.Include(x => x.Category);

            // var orders = ctx.orders;

            // foreach (var p in orders)
            // {
            //     System.Console.WriteLine(p);
            // }
        }

        // static void OldStuff()
        // {
        //     var ctx = new NorthwindContext();
        //     //var categories = ctx.categories;

        //     var products = ctx.products.Include(x => x.Category);



        //     foreach (var p in products)
        //     {
        //         System.Console.WriteLine(p);
        //     }

        // foreach (var cat in categories)
        // {
        //     System.Console.WriteLine(cat.ToString());
        // }

        // var c = new Category
        // {
        //     Id = 101,
        //     Name = "Boardgames",
        //     Description = "Best ones ever"
        // };

        //ctx.categories.Add(c);

        //ctx.categories.Remove(ctx.categories.Find(101));

        //ctx.SaveChanges();
        // }

    }
}
