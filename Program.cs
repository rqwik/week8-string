using System;

namespace StringsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string someString = "Hello Mary!"; //string - тип данных с текстом (символы) - КЛАСС
            //int someNumber = 5; //int - примитивный тип данных - СТРУКТУРА
            //int someBool = true; //bool - примитивное - всего лишь одно значение - true or false
            //char someChar = 'a'; //примитивное

            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            //int stringLenght = name.Length; - если убираем, то см.ниже
            Console.WriteLine($"In your name {name.Length} symbols"); //stringLenght - это в ковычках тогда
        }
    }
}
