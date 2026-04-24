using System;

namespace exercício_for
{
    class Program
    {
        static void Main()
        {
            int numero = 5;

            Console.WriteLine($"--- Tabuada do {numero} ---");

            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
            }

            Console.WriteLine("------------------------");

            Console.ReadKey();
        }
    }
}
