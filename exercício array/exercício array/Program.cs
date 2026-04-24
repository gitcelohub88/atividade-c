using System;

namespace exercício_array
{
    class Program
    {
        static void Main()
        {
            string[] nomes = { "Ana", "Bruno", "Carla", "Diego", "Elena" };

            Console.WriteLine("--- Todos os nomes ---");
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("\n--- Seleção específica ---");

            Console.WriteLine("Primeiro nome: " + nomes[0]);

            Console.WriteLine("Último nome: " + nomes[nomes.Length - 1]);

            Console.ReadLine();
        }
    }
}
