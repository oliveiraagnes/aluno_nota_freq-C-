using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno_nota_freq
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Faça um programa que leia 3 notas e a frequência total do aluno.
             * Exiba na tela "Reprovado" se a média for menor que 5.
             * Exiba na tela "Recuperação se a média for maior ou igual a 5 e a frequência menor que 75.
             * Exiba na tela "Aprovado" se a média for maior ou igual a 5 a frequência maior ou igual a 75.
             */


            int n1, n2, n3;
            string nome;
            double freq;

            Console.WriteLine("Aluno(a), qual é o seu nome?");
            nome = Console.ReadLine();

            Console.WriteLine($"{nome}, digite sua primeira nota: ");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{nome}, digite sua segunda nota: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{nome}, digite sua terceira nota: ");
            n3 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{nome}, qual é a sua frequência nessa instituição?");
            freq = double.Parse(Console.ReadLine());

            if ((n1+n2+n3)/3 < 5)
            {
                Console.WriteLine($"{nome}, você foi reprovado(a).");
            }
            else if ((n1 + n2 + n3) / 3 >= 5 && freq<75)
            {
                Console.WriteLine($"{nome}, você esta de recuperação.");
            }
            else
            {
                Console.WriteLine($"{nome}, você foi aprovado(a), parabéns!");
                Console.WriteLine("Continue assim!");
            }
        }
    }
}
