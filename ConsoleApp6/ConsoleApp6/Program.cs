using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            int N;
            int Resultado_numero;
            Console.WriteLine("escreva um nuemro desejado");
            N = int.Parse(Console.ReadLine());
            Resultado_numero = N % 2;
            if (Resultado_numero == 1)
            {
                Console.WriteLine("Numero impar");
            }
            else
            {
                Console.WriteLine("Numero è par");
            };
            Console.WriteLine(Resultado_numero);
            Console.ReadLine();
        }
}
}
