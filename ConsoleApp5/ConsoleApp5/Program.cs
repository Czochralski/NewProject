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
            //variáveis
            double a, b, x;
//inserir os valores digitado pelo usuário
            Console.WriteLine("Entre com o valor de A:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor de B:");
            b = double.Parse(Console.ReadLine());
//a lógica da operação
            x = -b / a;
//mostrar o resultado na tela do usuário
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
