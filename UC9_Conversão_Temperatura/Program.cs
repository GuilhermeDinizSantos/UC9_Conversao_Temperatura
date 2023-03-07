// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int escolha;
double celsius;
double fahrenheit;
double conversao1;

Console.WriteLine("Olá! Bem vindo ao aplicativo de conversão de temperatura");
Console.WriteLine("Para começar digite: ");
Console.WriteLine("1 para conversão CELSIUS -> FAHRENHEIT");
Console.WriteLine("2 para conversão FAHRENHEIT -> CELSIUS");
escolha = int.Parse(Console.ReadLine());

switch (escolha)
{
    case 1:
        Console.WriteLine("Conversão CELSIUS -> FAHRENHEIT foi escolhida");
        Console.WriteLine("Insira a temperatura em CELSIUS (°C");
        celsius = double.Parse(Console.ReadLine());

        conversao1 = (celsius * 9) / 5 + 32;

        Console.WriteLine("");

        break;

    case 2:

        break;

    default:
        break;
}
