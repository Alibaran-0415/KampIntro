using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop1
{
    public class ProductManager
    {
        public void Add(Product product)
        {
            //product.ProductName = "Camera";
            Console.WriteLine(product.ProductName+" eklendi!");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName+" güncellendi!");
        }

        public void DoSomething(int number1)
        {
            number1 = 99;
        }

        public int Sum1(int number1,int number2)
        {
            return number1 + number2;
        }        
        
        public void Sum2(int number1,int number2)
        {
            Console.WriteLine(number1 + number2); 
        }


    }
}
