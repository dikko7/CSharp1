using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите A и B:");
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int s = 1;
            for (int i = A; i <= B; i++)
            {
                s *= i;
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
