using System;

namespace exercício_switc {
}

    class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número de 1 a 7:");
        int dia = int.Parse(Console.ReadLine());

        switch (dia)
        {
            case 1:
                Console.WriteLine("1 - Domingo");
                break;
            case 2:
                Console.WriteLine("2 - Segunda-feira");
                break;
            case 3:
                Console.WriteLine("3 - Terça-feira");
                break;
            case 4:
                Console.WriteLine("4 - Quarta-feira");
                break;
            case 5:
                Console.WriteLine("5 - Quinta-feira");
                break;
            case 6:
                Console.WriteLine("6 - Sexta-feira");
                break;
            case 7:
                Console.WriteLine("7 - Sábado");
                break;
            default:
                Console.WriteLine("Número inválido! Digite apenas de 1 a 7.");
                break;
        }
    }
}