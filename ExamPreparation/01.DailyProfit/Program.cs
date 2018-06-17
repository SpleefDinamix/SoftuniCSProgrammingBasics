using System;
using System.Globalization;

namespace _01.DailyProfit
{
    class Program
    {
        static void Main()
        {
            int workDays = int.Parse(Console.ReadLine());
            double paymentPerDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double dollarRate = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var oneMonthPayment = workDays * paymentPerDay;
            var oneYearPayment = oneMonthPayment * 12d + oneMonthPayment * 2.5;
            var yearTax = 25d / 100d * oneYearPayment;
            var netAnnualIncome = oneYearPayment - yearTax;

            var netDayIncomeInBGN = netAnnualIncome / 365d * dollarRate;
            Console.WriteLine("{0:F2}", netDayIncomeInBGN);
        }
    }
}
