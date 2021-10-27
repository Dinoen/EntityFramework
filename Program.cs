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


        // Order
        public static void GetOrder(int orderId)
        {
            var dataSvc = new DataService();
            //dataSvc.CreateCategory(new Category { Id = 10, Name = "Boardgames2", Description = "Gloomhaven2" });
        }

        public static void GetOrderByShipName(string shipName)
        {

        }

        public static void GetOrders()
        {

        }

        // Order Details
        public static void GetOrderDetails(int orderDetailId)
        {

        }

        public static void GetOrderDetailsByProductId(int productId)
        {

        }

        //Product
        public static void GetProduct(int productId)
        {

        }

        public static void GetProductsBySubstring(string subString)
        {

        }

        public static void GetProductsByCategory(int categoryId)
        {

        }

        //Category
        public static void GetCategoryById(int categoryId)
        {

        }
        public static void GetCategories()
        {

        }
        public static void AddNewCategory(Category cat)
        {

        }

        public static bool UpdateCategory(int id, string name, string description)
        {
            return true;
        }
        public static bool DeleteCategory(int categoryId)
        {
            return true;
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
