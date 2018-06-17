using System;
using System.Globalization;

namespace _03.Styrofoam
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double houseArea = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int numOfWindows = int.Parse(Console.ReadLine());
            double styroPacketArea = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pricePerPacket = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var netArea = houseArea - numOfWindows * 2.4;
            var totalArea = netArea + 10d / 100d * netArea;
            var neededStyroPackets = Math.Ceiling(totalArea / styroPacketArea);
            var styroCost = neededStyroPackets * pricePerPacket;

            if (budget > styroCost)
            {
                Console.WriteLine("Spent: {0:F2}",styroCost);
                Console.WriteLine("Left: {0:F2}", budget - styroCost);
            }
            else
            {
                Console.WriteLine("Need more: {0:F2}", styroCost - budget);
            }
        }
    }
}
