using System;

namespace _11.EqualWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var word1 = Console.ReadLine().ToLower();
            var word2 = Console.ReadLine().ToLower();
            var result = word1 == word2 ? "yes" : "no";

            Console.WriteLine(result);
        }
    }
}
