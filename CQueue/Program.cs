using System;
using System.Collections.Generic;

namespace CQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("---------------- Fila ----------------");
            Console.WriteLine("--------------------------------------");

            Queue<Cliente> Pessoa = new Queue<Cliente>();

            Pessoa.Enqueue(new Cliente("Maria das Graças","70"));
            Pessoa.Enqueue(new Cliente("João Vitor","15"));
            Pessoa.Enqueue(new Cliente("José Souza","67"));
            Pessoa.Enqueue(new Cliente("Ismael Trindade","48"));
            Pessoa.Enqueue(new Cliente("Wylanda Veras","44"));
            Pessoa.Enqueue(new Cliente("Feliciano Gomes","39"));

            Console.WriteLine($"\n O primeiro Cliente é: {Pessoa.Dequeue()}");

            Pessoa.Peek();

            Console.WriteLine("\n ------------- Cadastro: --------------");

            foreach (var item in Pessoa)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("---------------------------------------");
            Console.WriteLine($" Nº de Clientes na Fila: {Pessoa.Count}");
            Console.WriteLine("---------------------------------------");
        }


        public class Cliente
        {
            public string Nome { get; set; }

            public string Idade { get; set; }

            public Cliente(string nome, string idade)
            {
                Nome = nome;
                Idade = idade;
            }


            public override string ToString()
            {
                return $" > {Nome}, {Idade} anos.";              
            }
        }
    }
}