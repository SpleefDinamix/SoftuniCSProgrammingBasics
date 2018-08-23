using System;

namespace _16.NumberTo100ToText
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string result = String.Empty;

            if (num >= 0 && num <= 15 || num == 100)
            {
                result = NumToText(num);
            }
            else if (num > 15 && num <= 19)
            {
                result = NumToText(num % 10) + "teen";
            }
            else if (num >= 20 && num < 100)
            {
                result = NumPrefixTwo(num / 10);
                if (num % 10 != 0)
                {
                    result += " " + NumToText(num % 10);
                }
            }
            else
            {
                result = "invalid number";
            }

            Console.WriteLine(result);
        }

        public static string NumPrefixTwo(int number)
        {
            string output = String.Empty;

            switch (number)
            {
                case 2:
                    output = "twenty";
                    break;

                case 3:
                    output = "thirty";
                    break;

                case 4:
                    output = "forty";
                    break;

                case 5:
                    output = "fifty";
                    break;

                case 6:
                    output = "sixty";
                    break;

                case 7:
                    output = "seventy";
                    break;

                case 8:
                    output = "eighty";
                    break;

                case 9:
                    output = "ninety";
                    break;

                default:
                    break;
            }
            return output;
        }

        public static string NumToText(int number)
        {
            string output = String.Empty;

            switch (number)
            {
                case 0:
                    output = "zero";
                    break;

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

                case 10:
                    output = "ten";
                    break;

                case 11:
                    output = "eleven";
                    break;

                case 12:
                    output = "twelve";
                    break;

                case 13:
                    output = "thirteen";
                    break;

                case 14:
                    output = "fourteen";
                    break;

                case 15:
                    output = "fifteen";
                    break;

                case 100:
                    output = "one hundred";
                    break;

                default:
                    break;
            }
            return output;
        }
    }
}
