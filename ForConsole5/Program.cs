using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N:");
            int N = int.Parse(Console.ReadLine());
            int s = 1;
            int f = 1;
            for (int e = 1; e <= N; e++)
            {
                for (int i = 1; i <= N; i++)
                    s += i;
                    f *= e;
            }
            Console.WriteLine("Факториал этого числа = " + s);
            Console.ReadKey();
        }
    }
}
