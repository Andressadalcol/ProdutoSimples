using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoSimples
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Leia dois valores inteiros. A seguir, calcule o produto entre estes dois valores e atribua esta operação à variável PROD. 
            A seguir mostre a variável PROD com mensagem correspondente.   
            
            int vl1, vl2, prod;

            
            Console.WriteLine("Valor 1: ");
            vl1= int.Parse(Console.ReadLine());
            Console.WriteLine("Valor 2: ");
            vl2 = int.Parse(Console.ReadLine());

            prod = vl1 * vl2;

            Console.WriteLine("Prod = " + prod);
            Console.ReadLine();

        }
    }
}
