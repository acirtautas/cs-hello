using System;

namespace HelloWorld
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Program requires at least two arguments");
                return;
            }

            var module = new HelloModule();

            Console.WriteLine(module.SayHello(args[0], args[1]));

            Console.ReadLine();
        }
    }
}
