﻿using System;

namespace _12.SpeedInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            var speed = double.Parse(Console.ReadLine());
            string result = String.Empty;

            if (speed <= 10)
            {
                result = "slow";
            }
            else if (speed <= 50)
            {
                result = "average";
            }
            else if (speed <= 150)
            {
                result = "fast";
            }
            else if (speed <= 1000)
            {
                result = "ultra fast";
            }
            else
            {
                result = "extremely fast";
            }

            Console.WriteLine(result);
        }
    }
}
