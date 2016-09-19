using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Console
{
    class Program3
    {
        static void Main(string[] args)
        {
            double a, b, x, y;
            Console.WriteLine("Введите значения a, b, x через enter: ");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            x = double.Parse(Console.ReadLine());
            y = 2.4 * (Math.Abs((x * x + b) / a)) + (a - b) * Math.Pow(Math.Sin(a-b), 2) + (Math.Pow(10, -2)) * (x-b);
            Console.WriteLine("y = " + y);
            Console.ReadKey();
        }
    }
}
