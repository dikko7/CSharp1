using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число A:");
            double A = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число N:");
            int N = int.Parse(Console.ReadLine());
            double s = 1;
            for (int i = 1; i <= N; i++)
                s *= A;
            Console.WriteLine(s);
        }
    }
}
