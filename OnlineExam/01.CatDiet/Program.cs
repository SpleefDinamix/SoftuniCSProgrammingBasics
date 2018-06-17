using System;

namespace _01.CatDiet
{
    class Program
    {
        static void Main()
        {
            int fats = int.Parse(Console.ReadLine());
            int proteins = int.Parse(Console.ReadLine());
            int carbs = int.Parse(Console.ReadLine());
            int totalCalories = int.Parse(Console.ReadLine());
            int water = int.Parse(Console.ReadLine());

            var totalFats = (fats / 100d * totalCalories) / 9d;
            var totalProteins = (proteins / 100d * totalCalories) / 4d;
            var totalCarbs = (carbs / 100d * totalCalories) / 4d;

            var foodWeight = totalFats + totalProteins + totalCarbs;
            var caloriesPerGram = totalCalories / foodWeight;

            var caloriesWithoutWater = caloriesPerGram * (1 - water / 100d);

            Console.WriteLine("{0:f4}",caloriesWithoutWater);
        }
    }
}
