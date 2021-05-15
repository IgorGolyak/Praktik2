using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1д
            Console.WriteLine("Введите число r1");
            int r1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число r2");
            int r2 = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            int v = i / r1 + i / r2;
            Console.WriteLine(v);
            Console.ReadKey();
        }
    }
}
