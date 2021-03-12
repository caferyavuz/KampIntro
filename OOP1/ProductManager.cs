using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+" sisteme eklendi.");
            Console.WriteLine("-------------------------------------");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " gücellendi.");
            Console.WriteLine("-------------------------------------");
        }
    }
}
