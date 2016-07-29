using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrado_Perfeito
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Digite um número:");
            num = int.Parse(Console.ReadLine()); 
            
            int soma = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    soma += i;
                }
                
            }

            if (soma == num)
            {

                Console.WriteLine("Numero Perfeito");
            }
            else
            {
                Console.WriteLine("Numero n perfeito");

            }
                Console.ReadKey();
            }

        }
    }

