using System;

namespace Atividade_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeUsuario;
            int anoNascimento, anoAtual, idadeUsuario;
            anoAtual = 2021;
            

            Console.WriteLine("Seja Bem Vindo ao Gerador de Senha da sua nova Plataforma de Streming");
            Console.WriteLine("Por gentileza, nos informe o seu nome?");
            nomeUsuario = Console.ReadLine();
            
            Console.WriteLine("Em qual ano você nasceu?");
            anoNascimento = int.Parse(Console.ReadLine());

            idadeUsuario = anoAtual - anoNascimento;
            
            if (idadeUsuario < 18)
            {
                Console.WriteLine("A SENHA da sua nova Plataforma de Streaming é: {0}{1}",nomeUsuario,idadeUsuario);

            }

            else
            {
                
                Console.WriteLine("A SENHA da sua nova Plataforma de Streaming é: {1}{0}",nomeUsuario,idadeUsuario);
            }
        }
       

    }
}
