// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.Write("Digite o valor da Gasolina: R$");
double gasolina = double.Parse(Console.ReadLine());
Console.Write("Digite o valor do Álcool: R$");
double alcool = double.Parse(Console.ReadLine());

double conta = alcool / gasolina * 100;
System.Console.WriteLine(conta.ToString("F2") + "%");

var mensagem = conta <= 65 ? "USE ALCOOL" : "USE GASOLINA";
System.Console.WriteLine("Resultado: " + mensagem);
