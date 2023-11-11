using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Program
    {
        static void Main(string[] args)
        {
            string productName = "Apple";
            double price = 30;
            string description = "Amasya Apple";

            string[] fruits = new string[]
            {
                "Apple","Watermelon"
            };

            Product product1 = new Product();
            product1.Id = 1;
            product1.Name = "Apple";
            product1.Price = 25;
            product1.Description = "Amasya Apple";

            Product product2 = new Product();
            product2.Id = 2;
            product2.Name = "Watermelon";
            product2.Price = 100;
            product2.Description = "Diyarbakır Watermelon";

            Product[] products = new Product[] {product1,product2};

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].Id);
                Console.WriteLine(products[i].Name);
                Console.WriteLine(products[i].Price);
                Console.WriteLine(products[i].Description);
                Console.WriteLine("-------------");
            }

            foreach (var item in products)
            {
                Console.WriteLine("Ürün Id:"+item.Id);
                Console.WriteLine("Ürün Adı:"+item.Name);
                Console.WriteLine("Ürün Ücreti:"+item.Price);
                Console.WriteLine("Ürün Açıklaması:"+item.Description);
                Console.WriteLine("------------");
            }

            BasketManager basketManager = new BasketManager();
            basketManager.Add(product1);
            basketManager.Add(product2);

            basketManager.Add2("Pear","Green Pear",12,90);
            basketManager.Add2("Apple","Green Apple",12,9);
            basketManager.Add2("Watermelon","Diyarbakır Watermelon ",12,8);
            Console.ReadLine();
        }
    }
}
