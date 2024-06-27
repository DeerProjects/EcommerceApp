using EcommerceApp.Models;
using EcommerceApp.Services;
using EcommerceApp.Utilities;
using System;
using EcommerceApp.Utilities;

namespace EcommerceApp
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Logger logger = new Logger();

            logger.LogInfo("This is and info message");
            logger.LogWarn("This is and warning message");
            logger.LogError("This is and error message");


            // Create products
            Product laptop = new Electronics("Laptop", 9999.999m, "MSU", 24);
            Product tshirt = new Clothing("T-shirt", 19.99m, "M", "Cotton");

            // Create order
            Order order = new Order();
            order.AddProduct(laptop);
            order.AddProduct(tshirt);

            //Display order details
            order.DisplayOrderDetails();
        }
    }
}