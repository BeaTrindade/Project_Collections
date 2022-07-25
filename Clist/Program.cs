using System;
using System.Collections.Generic;

namespace CList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("- Animais List! -");
            Console.WriteLine("-----------------");

            List<string> lista = new List<string>();

            lista.Add("Cachorro");
            lista.Add("Aranha");
            lista.Add("Rato");
            lista.Add("Mosca");

            lista.Insert(2,"Gato");

            lista.Remove("Mosca");
            lista.RemoveAt(1);

            foreach (string nome in lista)
            {
                Console.WriteLine($"Animal: {nome} \n");
            }
        }
    }
}
