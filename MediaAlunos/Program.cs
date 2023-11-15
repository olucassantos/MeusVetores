using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaAlunos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Crie um programa que peça o nome e 4 notas 
                de 10 alunos.Ao final o programa deve 
                mostrar a média de cada um dos alunos.
            */

            // Vetor para armazenar o nome dos alunos
            int quantidadeAlunos = 3;

            string[] alunos = new string[quantidadeAlunos];
            decimal[] mediasAlunos = new decimal[quantidadeAlunos];

            // Laço de repetição para solicitar o nome dos 10 alunos
            for(int indice = 0;  indice < alunos.Length; indice++)
            {
                Console.WriteLine($"Qual o nome do aluno {indice + 1}?");
                // Guarda na posição "indice" do vetor o nome digitado
                alunos[indice] = Console.ReadLine();

                // Repete 4 vezes para pegar as notas do aluno
                decimal mediaAluno = 0;
                for (int indice_notas = 1; indice_notas < 5; indice_notas++)
                {
                    Console.WriteLine($"Qual a nota {indice_notas} do aluno?");
                    mediaAluno += Convert.ToDecimal(Console.ReadLine());
                }

                mediasAlunos[indice] = mediaAluno / 4;
            }

            // Imprime o aluno e a média
            for (int indice = 0; indice < mediasAlunos.Length; indice++)
            {
                // Imprime o nome e a média do aluno
                Console.WriteLine($"O aluno {alunos[indice]} teve média: {mediasAlunos[indice]}");
            }
        }
    }
}
