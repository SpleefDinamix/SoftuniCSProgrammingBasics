using System;

namespace _12.CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var currencyInput = decimal.Parse(Console.ReadLine());
            var currencyType = Console.ReadLine();
            var currencyToConvert = Console.ReadLine();
            decimal result = 0.00M;

            switch (currencyType)
            {
                case "BGN":
                    switch (currencyToConvert)
                    {
                        case "EUR":
                            result = currencyInput / 1.95583M;
                            break;

                        case "GBP":
                            result = currencyInput / 2.53405M;
                            break;

                        case "USD":
                            result = currencyInput / 1.79549M;
                            break;
                    }
                    break;

                case "EUR":
                    switch (currencyToConvert)
                    {
                        case "BGN":
                            result = currencyInput * 1.95583M;
                            break;

                        case "GBP":
                            result = currencyInput * 1.95583M / 2.53405M;
                            break;

                        case "USD":
                            result = currencyInput * 1.95583M / 1.79549M;
                            break;
                    }
                    break;

                case "GBP":
                    switch (currencyToConvert)
                    {
                        case "BGN":
                            result = currencyInput * 2.53405M;
                            break;

                        case "EUR":
                            result = currencyInput * 2.53405M / 1.95583M;
                            break;

                        case "USD":
                            result = currencyInput * 2.53405M / 1.79549M;
                            break;
                    }
                    break;

                case "USD":
                    switch (currencyToConvert)
                    {
                        case "BGN":
                            result = currencyInput * 1.79549M;
                            break;

                        case "EUR":
                            result = currencyInput * 1.79549M / 1.95583M;
                            break;

                        case "GBP":
                            result = currencyInput * 1.79549M / 2.53405M;
                            break;
                    }
                    break;

                default:
                    break;
            }

            Console.WriteLine(Math.Round(result, 2) + " " + currencyToConvert);
        }
    }
}