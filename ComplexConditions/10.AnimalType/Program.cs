using System;

namespace _10.AnimalType
{
    class Program
    {
        static void Main(string[] args)
        {
            var animal = Console.ReadLine().ToLower();
            var _class = String.Empty;

            switch (animal)
            {
                case "dog":
                    _class = "mammal";
                    break;

                case "crocodile":
                    _class = "reptile";
                    break;

                case "tortoise":
                    _class = "reptile";
                    break;

                case "snake":
                    _class = "reptile";
                    break;

                default:
                    _class = "unknown";
                    break;
            }

            Console.WriteLine(_class);
        }
    }
}
