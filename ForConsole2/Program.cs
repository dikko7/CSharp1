using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N");
            double N = int.Parse(Console.ReadLine());
            double s = 1;
            for (double i = 1; i <= N; i++)
            s += 1 / i;
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
