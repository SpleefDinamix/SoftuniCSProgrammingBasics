using System;

namespace _08.MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentMetricValue = double.Parse(Console.ReadLine());
            var metricType = Console.ReadLine();
            var metricTypeToConvert = Console.ReadLine();

            double metricDevider = FindMetricValue(metricType);
            double metricMultiplyer = FindMetricValue(metricTypeToConvert);

            double result = currentMetricValue * metricMultiplyer / metricDevider;

            Console.WriteLine(result);
        }

        public static double FindMetricValue(string metricType)
        {
            switch (metricType)
            {
                case "mm":
                    return 1000d;

                case "cm":
                    return 100d;


                case "mi":
                    return 0.000621371192d;


                case "in":
                    return 39.3700787d;


                case "km":
                    return 0.001d;


                case "ft":
                    return 3.2808399d;


                case "yd":
                    return 1.0936133d;


                default:
                    return 1d;

            }
        }
    }
}
