using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Added" + product.Name);
        }
        public void AlternativeAdd(string productName,string description,double price,int unitsInStock)
        {
            Console.WriteLine("Added" + productName);
        }
    }
}
