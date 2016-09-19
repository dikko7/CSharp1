using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Console
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение сторон прямоугольника(a и b) через enter: ");
          
            int a, b;
            
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            int s = a * b;
            int p = (a + b) * 2;

            Console.WriteLine("Площадь S=" + s);
            Console.WriteLine("Периметр P=" + p);
            Console.ReadKey();
        }
    }
}
