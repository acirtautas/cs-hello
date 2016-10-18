using System;
using System.Globalization;

namespace HelloWorld
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length == 1)
            {
                var counter = new CounterModule();

                Console.WriteLine(counter.FindMax(args[0]));
                Console.ReadLine();

                return;
            }

            if (args.Length < 2)
            {
                Console.WriteLine("Program requires at least two arguments");
                return;
            }

            var module = new HelloModule();

            var culture = new CultureInfo("en-US");
            Console.WriteLine(module.SayHello(args[0], args[1], culture));

            Console.ReadLine();
        }
    }
}
