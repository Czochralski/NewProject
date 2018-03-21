using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, x;

            Console.WriteLine("Entre com o valor de A:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor de B:");
            b = double.Parse(Console.ReadLine());

            x = -b / a;

            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
