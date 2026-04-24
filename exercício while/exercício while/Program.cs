using System;

namespace exercício_while
{
    class Program
    {
        static void Main()
        {
            int contador = 1;

            while (contador <= 10)
            {
                Console.WriteLine(contador);

                contador++;
            }

            Console.ReadKey();
        }
    }
}