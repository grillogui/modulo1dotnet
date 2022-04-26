using Exercicio6Lista10.SRC;
using System;

namespace Exercicio6Lista10
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Formas Geométricas");

            Quadrado q1 = new Quadrado("quadrado", 10, 10);
            Retangulo r1 = new Retangulo("retangulo", 20, 10);
            Triangulo t1 = new Triangulo("triangulo", 10, 8);

            Console.WriteLine($"A area do {q1.Nome} de base {q1.Base} e altura {q1.Altura} é {q1.Area()}");
            Console.WriteLine($"A area do {r1.Nome} de base {r1.Base} e altura {r1.Altura} é {r1.Area()}");
            Console.WriteLine($"A area do {t1.Nome} de base {t1.Base} e altura {t1.Altura} é {t1.Area()}");
        }
    }
}
