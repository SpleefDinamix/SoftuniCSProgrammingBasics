using System;

namespace _05.NumbersToTenText
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            string output = String.Empty;

            switch (number)
            {
                case 1:
                    output = "one";
                    break;

                case 2:
                    output = "two";
                    break;

                case 3:
                    output = "three";
                    break;

                case 4:
                    output = "four";
                    break;

                case 5:
                    output = "five";
                    break;

                case 6:
                    output = "six";
                    break;

                case 7:
                    output = "seven";
                    break;

                case 8:
                    output = "eight";
                    break;

                case 9:
                    output = "nine";
                    break;

                default:
                    output = "number too big";
                    break;
            }

            Console.WriteLine(output);
        }
    }
}
