using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //13
            Console.WriteLine("Введите число 7x");
            double x7 = Convert.ToDouble(Console.ReadLine());
            double x1 = Math.Pow(x7, 2);
            double y = Math.Pow(x7, 2) - 3 + 6;
            Console.WriteLine(y);
            Console.ReadKey();

        }
    }
}
