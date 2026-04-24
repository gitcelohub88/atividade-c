using System;

namespace exercício_if
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insira sua idade");
            int idade = Convert.ToInt32(Console.ReadLine());
            if(idade<18)
            {
                Console.WriteLine("menor de idade");

            } 
            else if (idade>=18 && idade <= 59)
            {
                Console.WriteLine("adulto"); 
            }
            else
            {
                Console.WriteLine("idoso");
            }
        }
    }
}
