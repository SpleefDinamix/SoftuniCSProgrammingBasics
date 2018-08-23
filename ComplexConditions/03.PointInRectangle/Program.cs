using System;

namespace _03.PointInRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstX = double.Parse(Console.ReadLine());
            double firstY = double.Parse(Console.ReadLine());
            double secondX = double.Parse(Console.ReadLine());
            double secondY = double.Parse(Console.ReadLine());
            double pointX = double.Parse(Console.ReadLine());
            double pointY = double.Parse(Console.ReadLine());

            bool condition1 = pointX >= firstX && pointX <= secondX;
            bool condition2 = pointY >= firstY && pointY <= secondY;

            if (condition1 && condition2)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Outside");
            }
        }
    }
}
