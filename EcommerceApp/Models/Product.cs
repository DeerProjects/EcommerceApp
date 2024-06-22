using EcommerceApp.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp.Models
{
    public abstract class Product : IProduct
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        protected Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Product: {Name}, Price: {Price:C}");
        }
    }
}
