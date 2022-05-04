using System;

namespace OCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string hello = "Hello World!";

            for (int i = 0; i < hello.Length; i++)
            {
                if(hello[i] == 'o' || hello[i] == 'O')
                {
                    counter++;
                }
            }
            Console.WriteLine($"There are {counter} o's in your string.");

        }
    }
}
