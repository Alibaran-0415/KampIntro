using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop2
{
    public class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.FirstName = "Muhammet";
            customer1.LastName = "Baran";
            customer1.TcNo = "11111111111";
            customer1.CustomerNo = "5256537";

            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "59865";
            customer2.CompanyName = "codeacademy.co";
            customer2.VergiNo = "891226526525";

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CoorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            Console.ReadLine();
        }
    }
}
