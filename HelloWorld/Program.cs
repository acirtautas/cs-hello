using System;

namespace HelloWorld
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string name = args[0];

            Console.WriteLine(string.Format("Hello {0}!", name));

            Console.ReadLine();
        }
    }
}
