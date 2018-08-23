using System;
using System.Globalization;

namespace _13.A1000DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputDate = Console.ReadLine();
            var date = DateTime.ParseExact(inputDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            date = date.AddDays(1000 - 1);

            Console.WriteLine(date.ToString("dd-MM-yyyy"));
        }
    }
}
