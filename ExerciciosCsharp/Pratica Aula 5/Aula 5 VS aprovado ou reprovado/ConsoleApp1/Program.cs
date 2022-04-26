using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string cursoConcluido;
            string mensalidades;
            string devolverLivros;
            int quantidadeCurso = 25;

            Console.WriteLine("qual o seu nome:)");
              nome = Console.ReadLine();
            Console.WriteLine("Você concluiu todos os cursos? (sim ou não)");
              cursoConcluido = Console.ReadLine();
            Console.WriteLine("Você quitou todas as mensalidades? (sim ou não)");
              mensalidades = Console.ReadLine();
            Console.WriteLine("você devolveu todos os livros na biblioteca? (sim ou não)");  
              devolverLivros = Console.ReadLine();
            Console.WriteLine("você foi aprovado em quantos cursos??");
              quantidadeCurso = Convert.ToInt32(Console.ReadLine());


            if (cursoConcluido == "sim" && 
                mensalidades == "sim" && 
                devolverLivros == "sim" &&
                quantidadeCurso >= 25)
               {
                Console.WriteLine(nome + " Você foi Aprovado");
               }
             else
               {
                Console.WriteLine(nome + "você foi Reprovado");
               }
        }
    }
}
