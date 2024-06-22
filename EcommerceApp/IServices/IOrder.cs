using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp.IServices
{
    public interface IOrder
    {
        void AddProduct(IProduct product);
        void RemoveProduct(IProduct product);
        void DisplayOrderDetails();
    }
}
