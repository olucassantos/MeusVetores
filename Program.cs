using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeusVetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Passo a passo
            
                1 - Ler o nome e idade de 10 pessoas
                2 - Mostrar a lista e se é maior ou menor
            */

            // Cria os vetores
            string[] nomes = new string[2];
            int[] idades = new int[2];

            // Loop para repetir 10 vezes (o tamanho do vetor)
            for (int indice = 0; indice < nomes.Length; indice++)
            {
                Console.WriteLine($"Qual o nome da pessoa {indice + 1}?");
                nomes[indice] = Console.ReadLine();

                Console.WriteLine($"Qual a idade da pessoa {indice + 1}?");
                idades[indice] = Convert.ToInt32( Console.ReadLine() );
            }

            // Loop para ler o vetor e imprimir se tem mais ou menos de 18
            for (int indice = 0; indice < idades.Length; indice++) {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"{nomes[indice]} de {idades[indice]} anos");

                if (idades[indice] < 18)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" é menor de idade");

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" é maior de idade");
                }
            }
        }
    }
}
