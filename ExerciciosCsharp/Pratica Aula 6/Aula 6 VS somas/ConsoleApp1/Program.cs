using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;


            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"Entre com o {i}º valor que deseja somar: ");
                valor += int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Somatoria: {valor}");
        }
    }
}
