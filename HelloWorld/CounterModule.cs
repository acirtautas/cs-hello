using System;
using System.Linq;

namespace HelloWorld
{
    public class CounterModule
	{
        public char FindMax(string text)
        {
            int[] frequencies = new int[(int)char.MaxValue];

            foreach (char t in text)
            {
                frequencies[(int)t]++;
            }

            char ch = (char) frequencies.ToList().IndexOf(frequencies.Max());

            return ch;
        }
    }
}
