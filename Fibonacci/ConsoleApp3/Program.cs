using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {

        //Função Fibonacci
        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        static void Main()
        {

            //Variavel para contar a quantidade
            int cont;

            //Pedi um valor ao usuario para o cont
              Console.WriteLine("Informe a quantidade");
            cont = int.Parse(Console.ReadLine());

            for (int i = 0; i <=
                cont; i++)
            {
                //Chama a função Fibonacci e mostra na tela o resultado
                Console.WriteLine(Fibonacci(i));
                Console.ReadLine();



            }
        }
    }
}
