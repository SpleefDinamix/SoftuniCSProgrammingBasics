using System;

namespace _05.CatWatch
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n-2; i++)
            {
                string air = new String(' ', n / 2);
                string band = "||" + new String('_', n - 2) + "||";
                Console.WriteLine(air + band + air);
            }

            string theAir = new String(' ', n / 2 -1);
            Console.Write( theAir +"//" + new String(' ', n));
            Console.WriteLine(@"\\" + theAir);

            
            theAir = new String(' ', n / 2 - 2);
            for (int i = 0; i < n - 4; i++)
            {
                int index = (n - 4) / 2;
                if (n % 2 == 0)
                {
                    index--;
                }


                if (index == i)
                {
                    Console.WriteLine(theAir + "||" + new String(' ', n + 2) + "||]");
                }
                else
                {
                    Console.WriteLine(theAir + "||" + new String(' ', n + 2) + "||");
                }
            }

            theAir = new String(' ', n / 2 - 1);
            Console.Write(theAir + @"\\" + new String(' ', n));
            Console.WriteLine("//" + theAir);

            for (int i = 0; i < n - 2; i++)
            {
                string air = new String(' ', n / 2);
                string band = "||" + new String('_', n - 2) + "||";
                Console.WriteLine(air + band + air);
            }
        }
    }
}
