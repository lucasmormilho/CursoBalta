using System;

namespace Calculator
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
            System.Console.WriteLine("O que deseja fazer?");
            System.Console.WriteLine("1 - Soma");
            System.Console.WriteLine("2 - Substracao");
            System.Console.WriteLine("3 - Divisao");
            System.Console.WriteLine("4 - Multiplicação");
            System.Console.WriteLine("5 - Sair");

            System.Console.WriteLine("------------------");
            System.Console.WriteLine("Escolha um valor:");

            short res = short.Parse(System.Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5:
                    System.Environment.Exit(0); break;
                default:
                    Menu(); break;
            }


        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            System.Console.WriteLine();

            float resultado = v1 + v2;
            System.Console.WriteLine("Resultado da soma: " + resultado);
            // System.Console.WriteLine($"Resultado da soma: {resultado}");
            // System.Console.WriteLine($"Resultado da soma: {v1 + v2}");
            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            System.Console.WriteLine();

            float resultado = v1 - v2;
            System.Console.WriteLine($"Resultado da soma: {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            System.Console.WriteLine();

            float resultado = v1 / v2;
            System.Console.WriteLine($"Resultado da soma: {resultado}");
            Console.ReadKey();
            Menu();

        }
        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            System.Console.WriteLine();

            float resultado = v1 * v2;
            System.Console.WriteLine($"Resultado da soma: {resultado}");
            Console.ReadKey();
            Menu();
        }
    }
}
