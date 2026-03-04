using System;

namespace testreadline
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter username:");

            string userName = Console.ReadLine();

            Console.WriteLine("Username is: " + userName);

            //Console.WriteLine("Enter your age:");
            // int age = Console.ReadLine();
            // Console.WriteLine("Your age is:" + age);
            // The error message will be something like this:





            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine ());
            Console.WriteLine("Your age is: " + age);


        }
    }
}
