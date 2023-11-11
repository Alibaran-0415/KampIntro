using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            names.Add("Muhammet");
            names.Add("Helin");
            names.Add("Kaan");
            Console.WriteLine(names.Length);
            names.Add("Ayşe");
            Console.WriteLine(names.Length);

            foreach (var name in names.Items)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
