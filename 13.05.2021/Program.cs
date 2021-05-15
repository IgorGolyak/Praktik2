using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._05._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 a
            Console.WriteLine("Введите число x1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число x2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число x3");
            int x3 = Convert.ToInt32(Console.ReadLine());
            int m1 = x1 * x2 + x1 * x3 + x2 * x3;
            Console.WriteLine(m1);
            Console.ReadKey();
        }
    }
}
