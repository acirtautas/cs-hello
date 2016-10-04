using System;

namespace HelloWorld
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string name = args[0];

            Console.WriteLine("Hello "+name+"!");

            Console.ReadLine();
        }
    }
}
