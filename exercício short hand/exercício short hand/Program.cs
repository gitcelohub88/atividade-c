using System;

namespace exercício_short_hand
{
    class Program
    {
        static void Main()
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            // O Operador Ternário funciona assim: condição ? se_verdade : se_falso
            string resultado = (numero % 2 == 0) ? "número par" : "número ímpar";

            Console.WriteLine(resultado);
        }
    }
}