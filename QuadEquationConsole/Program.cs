using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadEquationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите коэфициенты(a, b, c) квадратного уравнения: ");
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            double d = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine("Дискриминант d = " + d);
            double x1 = (-b + Math.Sqrt(d)) / 2 * a;
            double x2 = (-b - Math.Sqrt(d)) / 2 * a;
            if (d < 0)
                Console.WriteLine("Нет корней");
            else
         if (d == 0)
            {
                Console.WriteLine("x = " + x1);
            }
            else
            {
               Console.WriteLine ("x1 = " + x1);
               Console.WriteLine ("x2 = " + x2);
            }
            Console.ReadKey();
        }
    }
}
