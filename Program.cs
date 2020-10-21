using System;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Quantos alunos irão alugar quartos? ");
            int quantidade = int.Parse(Console.ReadLine());

            Alunos[] quartos = new Alunos[10];


            for (int i = 1; i <= quantidade; i++)
            {
                Console.WriteLine("Aluno #" + i + ": ");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("E-mail: ");
                string email = Console.ReadLine();

                Console.Write("Numero do quarto: ");
                int numeroQuarto = int.Parse(Console.ReadLine());


                quartos[numeroQuarto] = new Alunos(nome, email, numeroQuarto);

            }

            Console.WriteLine("Quartos ocupados: ");

            Alunos alunosConsole = new Alunos();

            for (int i = 0; i <= 9; i++)
            {
                if (quartos[i] != null)
                {
                    Console.WriteLine(quartos[i]);
                }
            }
        }
    }
}

