using System;
using System.IO;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            System.Console.WriteLine("O que você deseja fazer ?");
            System.Console.WriteLine("1 - Abrir arquivo");
            System.Console.WriteLine("2 - Criar novo arquivo");
            System.Console.WriteLine("0 - Sair");

            short opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
                default: Menu(); break;
            }

        }
        static void Abrir()
        {

        }
        static void Editar()
        {
            Console.Clear();
            System.Console.WriteLine("Digite seu texto abaixo (ESC para sair):");
            System.Console.WriteLine("---------------------");

            string text = "";

            //enquanto o ESC não for clicado
            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
            Console.Write(text)
        }
        static void Salvar(string text)
        {
            Console.Clear();
            System.Console.WriteLine("Qual caminho para salvar o caminho?");
            var path = Console.ReadLine();

            //usar using para abrir e fechar
            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }
            System.Console.WriteLine("Salvo com sucesso!");
            Menu();
        }
    }
}
