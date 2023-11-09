using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.Name + "Added");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.Name + "Updated");
        }
        public int CalculateSum(int value1, int value2)
        {
            return value1 + value2;
        }
        public void CalculateSum2(int value1, int value2)
        {
            Console.WriteLine(value1 + value2);
        }
    }
}
