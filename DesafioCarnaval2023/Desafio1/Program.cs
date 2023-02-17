// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite um texto:");

var texto = Console.ReadLine();

int qtdCaracteres = texto.Count();

int qtdPalavras = texto.Split(" ").Count();

if (texto.Count() == 0)
    System.Console.WriteLine("Sem texto");
else
{
    Console.WriteLine(qtdCaracteres + " caracteres, " + qtdPalavras + " palavras");
}


