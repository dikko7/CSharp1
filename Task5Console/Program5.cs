using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5Console
{
    class Program5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значения x, y, z через enter: ");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            
            double t = (2 * Math.Cos(x - Math.PI)) / (0.5 + Math.Pow(Math.Sin(y), 2)) * (1 + (z * z) / ((3 - z * z) / 5));
            Console.WriteLine("t = " + t);
            Console.ReadKey();
        }
    }
}