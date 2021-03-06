using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.ProductName = "Masa";
            product1.CategoryId = 2;
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;
            
            Product product2 = new Product {
                Id=2, ProductName="Sandalye", CategoryId=2,
                UnitPrice=200, UnitsInStock=5 };

            //PascalCase   //camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Add(product2);

        }
    }
}
