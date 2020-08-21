using System;
using System.Collections.Generic;

namespace POO_ClassePessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantidade de pessoas: ");
            int quant = int.Parse(Console.ReadLine());

            List<Pessoa> p1 = new List<Pessoa>();

            for (int i = 0; i < quant; i++)
            {
                Console.Write("\nNome: ");
                string nome = Console.ReadLine();

                Console.Write("Endereco: ");
                string endereco = Console.ReadLine();

                Console.Write("telefone: ");
                string telefone = Console.ReadLine();

                p1.Add(new Pessoa(nome, endereco, telefone));
            }

            Console.Clear();

            foreach (var p in p1)
            {
                Console.WriteLine(p);
            }
        }
    }
}
