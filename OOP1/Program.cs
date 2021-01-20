using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Id = 5;
            product.CategoryId = 2;
            product.ProdoctName = "monitör";
            product.UnitPrice = 250;
            product.UnitsInStock = 20;

            ProductManager productManager = new ProductManager();
            productManager.Add(product);
        }
    }
}
