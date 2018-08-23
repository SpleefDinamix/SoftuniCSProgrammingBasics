using System;

namespace _13.AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();

            if (figure == "circle")
            {
                var r = double.Parse(Console.ReadLine());
                var area = Math.Round(r * r * Math.PI, 3);
                Console.WriteLine(area);
            }
            else if (figure == "square")
            {
                var a = double.Parse(Console.ReadLine());
                var area = Math.Round(a * a, 3);
                Console.WriteLine(area);
            }
            else if (figure == "rectangle")
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                var area = Math.Round(a * b, 3);
                Console.WriteLine(area);
            }
            else if (figure == "triangle")
            {
                var a = double.Parse(Console.ReadLine());
                var h = double.Parse(Console.ReadLine());
                var area = Math.Round(a * h / 2, 3);
                Console.WriteLine(area);
            }
        }
    }
}
