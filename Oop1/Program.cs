using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName ="Masa";
            product1.UnitPrice = 1000;
            product1.UnitsInStock = 5;

            Product product2 = new Product { 
            Id=2,CategoryId=3,ProductName="Kalem",
                UnitPrice = 50,
                UnitsInStock = 10
            };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
           
            int number1 = 100;
            productManager.DoSomething(number1);
            Console.WriteLine(number1); //100


            productManager.Sum2(3,6);
            int result = productManager.Sum1(3,6);
            Console.WriteLine(result*2+4);
            Console.ReadLine();
        }
    }
}
