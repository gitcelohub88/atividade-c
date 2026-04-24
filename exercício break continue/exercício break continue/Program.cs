using System;

namespace exercício_break_continue
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 1;
            while (numero < 10)
                
            {
                if (numero == 5)
                {
                    numero++;
                    continue;
                    
                }
                else if (numero == 9)
                {
                    break;
                }
                
                Console.WriteLine(numero);
                numero++;
            }
                
        }
    }
}
