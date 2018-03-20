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
            //adicionar nova parte do codigo

            //Variaveis 
            double A;
            double Resultado;
           

            //Logica da operação
            Console.WriteLine("Digite um valor");
            A = double.Parse(Console.ReadLine());

            Resultado = 0.1 *A;
           
            Console.WriteLine(Resultado);
            Console.ReadLine();
        }
    

    static void Segundo(string[] args)
    {

        //Variaveis 
        double Porcentagem;
        double N;
        double Resultado;


    
            //Logica da operação
            Console.WriteLine("Digite o valor da porcentagem");
            Porcentagem = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da porcentagemdo numero");
            N = double.Parse(Console.ReadLine());

            Resultado = ((double)Porcentagem/100)*N;

        Console.WriteLine(Resultado);
        Console.ReadLine();
    }
}
}
