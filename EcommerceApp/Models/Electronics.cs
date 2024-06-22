using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp.Models
{
    public class Electronics : Product
    {
        public string Brand {  get; set; }
        public int WarrantPeriod {  get; set; }

        public Electronics(string name, decimal price,string brand, int warrantPeriod)
            : base(name,price)
        {
            Brand = brand;
            WarrantPeriod = warrantPeriod;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Brand: {Brand}, Warrant Period: {WarrantPeriod} months");
        }
    }
}
