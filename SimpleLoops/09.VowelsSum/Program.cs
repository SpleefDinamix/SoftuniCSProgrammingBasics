using System;
using System.Linq;

namespace _09.VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            string text = Console.ReadLine();
            int count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (vowels.Contains(text[i]))
                {
                    count += Array.IndexOf(vowels, text[i]) + 1;
                }
            }

            Console.WriteLine(count);
        }
    }
}
