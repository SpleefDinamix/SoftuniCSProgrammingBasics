using System;

namespace _07.Cup
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sideCount = n;
            int middleCount = 3 * n;

            for (int i = 0; i < n/2; i++)
            {
                string sidePart = new String('.', sideCount);
                string middlePart = new String('#', middleCount);

                Console.Write(sidePart);
                Console.Write(middlePart);
                Console.WriteLine(sidePart);

                sideCount++;
                middleCount -= 2;
            }

            /*
                    ......##################......
                    .......################.......
                    ........##############........
                    .........#..........#.........
                    ..........#........#..........
                    ...........#......#...........
                    ............#....#............
                    ............######............
                    ..........##########..........
                    ..........##########..........
                    ..........##########..........
                    ..........D^A^N^C^E^..........
                    ..........##########..........
                    ..........##########..........
                    ..........##########..........
                    ..........##########..........
            */
            middleCount -= 2;

            for (int i = 0; i < n/2 + 1; i++)
            {
                string sidePart = new String('.', sideCount);
                string middlePart = new String('.', middleCount);

                Console.Write(sidePart);
                Console.Write('#' + middlePart + '#');
                Console.WriteLine(sidePart);

                sideCount++;
                middleCount -= 2;
            }

            Console.Write(new String('.', 2*n));
            Console.Write(new String('#', n));
            Console.WriteLine(new String('.', 2 * n));

            for (int i = 0; i < n/2; i++)
            {
                Console.Write(new String('.', 2 * n - 2));
                Console.Write(new String('#', n + 4));
                Console.WriteLine(new String('.', 2 * n - 2));
            }

            Console.Write(new String('.', (5*n - 10)/2));
            Console.Write("D^A^N^C^E^");
            Console.WriteLine(new String('.', (5 * n - 10) / 2));

            for (int i = 0; i < n / 2 + 1; i++)
            {
                Console.Write(new String('.', 2 * n - 2));
                Console.Write(new String('#', n + 4));
                Console.WriteLine(new String('.', 2 * n - 2));
            }
        }
    }
}
