using System;

namespace StringAndIndexes
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = ("Hello World!"); //hello - это название контейнера, в котором хранится "Привет мир"
            Console.WriteLine(hello[0]);
            Console.WriteLine(hello[hello.Length-1]); //hello.Length - индекс
        }
    }
}
