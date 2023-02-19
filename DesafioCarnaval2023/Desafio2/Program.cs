// See https://aka.ms\r\new-console-template for more information
Console.Clear();
Console.WriteLine("Vamos calcular seu IMC");
System.Console.WriteLine("------------------------");
System.Console.Write("Digite seu peso, separados por virgula:");
double peso = double.Parse(Console.ReadLine());
System.Console.Write("Agora, digite sua altura, separados por virgula:");
double altura = double.Parse(Console.ReadLine());
System.Console.WriteLine("------------------------");
double imc = (peso / (altura * altura));
System.Console.WriteLine($"Seu IMC é de {imc.ToString("F2")}");
Imc(imc);

static void Imc(double imc)
{

    if (imc < 18.5) System.Console.WriteLine("VOCÊ ESTÁ ABAIXO DO PESO");
    if (imc >= 18.5 && imc <= 24.9) System.Console.WriteLine("VOCÊ ESTÁ COM PESO NORMAL");
    if (imc >= 25 && imc <= 29.9) System.Console.WriteLine("VOCÊ ESTÁ COM PRÉ OBESIDADE");
    if (imc >= 30 && imc <= 34.9) System.Console.WriteLine("VOCÊ ESTÁ COM OBESIDADE GRAU 1");
    if (imc >= 35 && imc <= 39.9) System.Console.WriteLine("VOCÊ ESTÁ COM OBESIDADE GRAU 2");
    if (imc > 40) System.Console.WriteLine("VOCÊ ESTÁ OBESIDADE GRAU 3");

    System.Console.WriteLine("------------------------");
    System.Console.WriteLine("fonte: OMS ( Organização Mundial da Saúde )");
}


