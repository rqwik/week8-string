using System;

namespace RandomLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter your name:");
            string name = Console.ReadLine();
            Random rnd = new Random();
            int randomletter = rnd.Next(0, name.Length);
            Console.WriteLine($"Random letter from your name: {name[randomletter]}");
            
        }
    }
}
