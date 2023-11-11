using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*string[] names = new string[] {"Muhammet","Murat","Kerem","Halil"};
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);

            names = new string[5];
            names[4] = "İlker";
            Console.WriteLine(names[4]);
            Console.WriteLine(names[0]);*/

            List<string> names2 = new List<string>
            {
                "Muhammet","Murat","Kerem","Halil"
            };

            Console.WriteLine("------İlk Hali------");
            for (int i = 0; i < names2.Count; i++)
            {
                Console.WriteLine(names2[i]);
            }

            names2.Add("İlker");
            Console.WriteLine("------Son Hali------");

            for (int i = 0; i < names2.Count; i++)
            {
                Console.WriteLine(names2[i]);
            }
            Console.ReadLine();
        }
    }
}
