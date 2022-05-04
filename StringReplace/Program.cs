using System;

namespace StringReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "R3pl4c3 ch4r4ct3r";
            string updatedname = name.Replace("3", "e");
            updatedname = updatedname.Replace("4", "a");
            Console.WriteLine(name);
            Console.WriteLine("==>>");
            Console.WriteLine(updatedname);
        }
    }
}
