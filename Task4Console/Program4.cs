using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4Console
{
    class Program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значения x, y, z через enter: ");
            double x, y, z;
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            z = double.Parse(Console.ReadLine());
            double f = (Math.Pow(y + Math.Pow((x - 1), 1 / 3), 1 / 4)) / (Math.Abs(x - y) * (Math.Pow(Math.Sin(z), 2) + Math.Tan(z)));
            Console.WriteLine("f = " + f);
            Console.ReadKey();
        }
    }
}
