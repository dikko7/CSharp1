using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task2Console
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значения m и n через enter: ");
            double m, n, z1, z2;
            m = double.Parse(Console.ReadLine());
            n = double.Parse(Console.ReadLine());
            z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(m * m * m * n) + n * m + m * m - m);
            z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
            Console.WriteLine("z1 = " + z1);
            Console.WriteLine("z2 = " + z2);
            Console.ReadKey();
        }
    }
}
