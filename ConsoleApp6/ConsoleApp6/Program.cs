using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//PROGRAMA PARA VER SE NUMERO É PAR OU IMPAR DE N NUMEROS
namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
                   //VARIAVEIS
            int N;
            int Resultado_numero;
            Console.WriteLine("escreva um nuemro desejado");
            N = int.Parse(Console.ReadLine());
            Resultado_numero = N % 2;
             // CONDIÇÃO DE PARA SER IMPAR
            if (Resultado_numero == 1)
            {
                Console.WriteLine("Numero impar");
            }
            //CONDIÇÃO PARA SER PAR
            else
            {
                Console.WriteLine("Numero è par");
            };
            //RESULTADO DA OPERAÇÃO
            Console.WriteLine(Resultado_numero);
            Console.ReadLine();
        }
}
}
