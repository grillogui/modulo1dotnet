using Exercicio5Lista8MetodoMain.src;
using System;

namespace Exercicio5Lista8MetodoMain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("quantos graus está: ");
            int temperatura = int.Parse(Console.ReadLine());

            if (temperatura < 15)
            { 
            Console.WriteLine("Montando o outfit");
            Roupa pe  = new Roupa("Tenis", "41", "branco", "Jordan");
            Roupa perna = new Roupa("Calça", "44", "preta", "Rener");
            Roupa tronco = new Roupa("Moletom", "GG", "Preto", "Nike");
            Roupa acessorio1 = new Roupa("touca", "M", "preta", "Vans" );

                Console.WriteLine("use");
            Console.WriteLine($"{pe.Tipo} {pe.Cor} da {pe.Marca}");
            Console.WriteLine($"{perna.Tipo} {perna.Cor} da {perna.Marca}");
            Console.WriteLine($"{tronco.Tipo} {tronco.Cor} da {tronco.Marca} tamanho {tronco.Tamanho}");
            Console.WriteLine($"{acessorio1.Tipo} {acessorio1.Cor} da {acessorio1.Marca}");
            }
            
            else if (temperatura <25)
            {
                Console.WriteLine("Montando o outfit");
                Roupa pe = new Roupa("Tenis", "41", "azul", "Mizuno");
                Roupa perna = new Roupa("bermuda", "42", "preta", "Ciclone");
                Roupa tronco = new Roupa("Camiseta polo", "M", "azul", "Lacoste");
                Roupa acessorio1 = new Roupa("Correntinha", "unico", "prata", " ");

                Console.WriteLine("use");
                Console.WriteLine($"{pe.Tipo} {pe.Cor} da {pe.Marca}");
                Console.WriteLine($"{perna.Tipo} {perna.Cor} da {perna.Marca}");
                Console.WriteLine($"{tronco.Tipo} {tronco.Cor} da {tronco.Marca} tamanho {tronco.Tamanho}");
                Console.WriteLine($"{acessorio1.Tipo} de {acessorio1.Cor}");
            }

            else
            {
                Console.WriteLine("Montando o outfit");
                Roupa pe = new Roupa("chinelo", "41", "branca", "Havaianas");
                Roupa perna = new Roupa("bermuda", "42", "preta", "Ciclone");
                Roupa tronco = new Roupa("Camiseta do Brasil", "G", "branca", "nike");
                Roupa acessorio1 = new Roupa("lupa", "unico", "24 K", "oakley");

                Console.WriteLine("use");
                Console.WriteLine($"{pe.Tipo} {pe.Cor} da {pe.Marca}");
                Console.WriteLine($"{perna.Tipo} {perna.Cor} da {perna.Marca}");
                Console.WriteLine($"{tronco.Tipo} {tronco.Cor} da {tronco.Marca} tamanho {tronco.Tamanho}");
                Console.WriteLine($"{acessorio1.Tipo} {acessorio1.Cor} da {acessorio1.Marca}");
            }

            Console.WriteLine("agora você ta chave");
        }
        
    } 
}
    

