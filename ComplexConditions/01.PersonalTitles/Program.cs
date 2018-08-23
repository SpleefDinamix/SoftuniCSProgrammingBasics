using System;

namespace _01.PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = double.Parse(Console.ReadLine());
            var gender = Console.ReadLine();
            string pronounce = String.Empty;

            if (gender == "m")
            {
                if (age < 16)
                {
                    pronounce = "Master";
                }
                else
                {
                    pronounce = "Mr.";
                }
            }
            else if (gender == "f")
            {
                if (age < 16)
                {
                    pronounce = "Miss";
                }
                else
                {
                    pronounce = "Ms.";
                }
            }
            Console.WriteLine(pronounce);
        }
    }
}
