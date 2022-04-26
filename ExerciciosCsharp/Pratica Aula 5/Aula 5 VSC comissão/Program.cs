 using System;

namespace Aula_5_VSC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o valor total das vendas desse mês?");
            double valorTotal = double.Parse(Console.Readline());
             
             if (valorTotal <= 10000)
             {
                 Console.WriteLine("O Valor a Receber é: R$ " + (valorTotal * 0.01));
             }
             else if (valorTotal <= 20000)
             {
                 Console.WriteLine("O Valor a Receber é: R$ " + (valorTotal * 0.02));
             }
             else if (valorTotal <= 30000)
             {
                 Console.WriteLine("O Valor a Receber é: R$ " + (valorTotal * 0.03));
             }
             else if (valorTotal <= 40000)
             {
                 Console.WriteLine("O Valor a Receber é: R$ " + (valorTotal * 0.04));
             }
             else if (valorTotal <= 50000)
             {
                 Console.WriteLine("O Valor a Receber é: R$ " + (valorTotal * 0.05));
             }
             else
             {
                 Console.WriteLine("O Valor a Receber é: R$ " + (valorTotal * 0.1));
             }
        }
    }
}
