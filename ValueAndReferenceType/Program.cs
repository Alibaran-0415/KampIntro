using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndReferenceType
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 30;
            number1 = number2;
            number2 = 65;
            Console.WriteLine(number1);

            int[] numbers1 = new int[] {10,20,30};
            int[] numbers2 = new int[] {100,200,300};

            numbers1 = numbers2;
            numbers2[0] = 9999;
            for (int i = 0; i < numbers2.Length; i++)
            {
                Console.WriteLine(numbers2[i]);
            }



            Console.ReadLine();
        }
    }
}
