using System;
using System.Linq;
using System.Collections.Generic;


namespace CStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("---------------- Biblioteca ---------------");
            Console.WriteLine("-------------------------------------------");

            Stack<string> Livros = new Stack<string>();

            Livros.Push(" > A Casa Sonolenta");
            Livros.Push(" > Jardim Secreto");
            Livros.Push(" > Diario de um Banana");

            Console.WriteLine($" 1º livro da pilha: {Livros.Peek()}");
            Console.WriteLine("-------------------------------------------");

            foreach (String livro in Livros)
            {
                Console.WriteLine($"livros: {livro}");
            }

            Livros.Pop();

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($" livros restantes: {Livros.Count()}");
            Console.WriteLine("-------------------------------------------");
        }
    }
}