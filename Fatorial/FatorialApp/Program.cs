using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial
{
    class Program
    {

        static void Main(string[] args)
        {
            //Variavel
            int valor;

            //Pedi um valor para o usuario e guarda na variavel valor
            Console.WriteLine("Entre com o valor:");
            valor = int.Parse(Console.ReadLine());

            //Chama a função fatorial com o valor q o usuario digitou e mostra na tela
            Console.WriteLine(Fatorial(valor));
            Console.ReadKey();


        }


        //Função fatorial, Logica da operação
        static int Fatorial( int i){
            
               if(i <= 1){
                Fatorial = 1;

               }else{
                (i * Fatorial (i - 1)) ;
                }

          
    }




     }
    }


 

























