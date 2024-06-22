using EcommerceApp.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp.Services
{
    public class Order : IOrder
    {
        private List<IProduct> products;

        public Order() 
        {
            products = new List<IProduct>();
        }
        public void AddProduct(IProduct product) 
        {
            products.Add(product);
        }
        public void RemoveProduct(IProduct product) 
        {
            products.Remove(product);
        }
        public void DisplayOrderDetails()
        {
            Console.WriteLine("Order Details: ");
            foreach (var product in products)
            {
                product.DisplayDetails();
            }
        }
    }
}
