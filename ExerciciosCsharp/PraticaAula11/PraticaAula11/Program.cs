using System;
using System.Collections.Generic;

namespace PraticaAula11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista!");

            List<string> lista = new List<string>();

            lista.Add("Gui");
            lista.Add("Elaine");
            lista.Add("Marcelo");
            lista.Add("Pamela");

            foreach (string item in lista)
            {
                Console.WriteLine(item);
            }

        }
    }
}
