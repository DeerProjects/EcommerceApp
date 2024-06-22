using EcommerceApp.Models;
using EcommerceApp.Services;
using System;

namespace EcommerceApp
{
    class Program
    {
        public static void Main(string[] args) 
        {
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