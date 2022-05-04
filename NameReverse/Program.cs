using System;

namespace NameReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Your name will be reversed is:");
            Console.WriteLine();

            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(name[i]);
            }
        }
    }
}
