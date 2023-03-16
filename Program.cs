using System;

namespace Mud 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");
            Console.Write("> ");
            string? input = Console.ReadLine();

            if (input != null)
            {
                Console.WriteLine(input);
            }
        }
    }
}