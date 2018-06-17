using System;

namespace _06.Cake
{
    class Program
    {
        static void Main()
        {
            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            int cakeParts = height * width;
            var inputLine = Console.ReadLine();
            bool eatenCake = false;

            while (inputLine != "STOP")
            {
                int takenParts = int.Parse(inputLine);

                if (cakeParts - takenParts >= 0)
                {
                    cakeParts -= takenParts;
                }
                else
                {
                    int neededParts = takenParts - cakeParts;
                    Console.WriteLine("No more cake left! You need {0} pieces more.", neededParts);
                    eatenCake = true;
                    break;
                }
                inputLine = Console.ReadLine();
            }
            if(!eatenCake)
            Console.WriteLine(cakeParts + " pieces are left.");
        }
    }
}
