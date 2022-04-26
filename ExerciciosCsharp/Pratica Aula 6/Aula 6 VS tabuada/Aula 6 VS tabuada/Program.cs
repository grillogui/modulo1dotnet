using System;

namespace Aula_6_VS_tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TABUADA");

            for (int X = 1; X <= 10; X++)
            {
               for (int Y = 1; Y <= 10; Y++)
               {
                    Console.WriteLine(X + " x " + Y + " = " + X * Y);
               }

            }

        }
    }
}
