using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp.Models
{
    public class Clothing : Product
    {
        public string Size { get; set; }
        public string Metarial { get; set; }

        public Clothing(string name, decimal price, string size, string metarial)
            : base(name, price)
        {
            Size = size;
            Metarial = metarial;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Size: {Size}, Metarial: {Metarial}");
        }
    }
}
