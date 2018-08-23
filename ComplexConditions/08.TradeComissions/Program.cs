using System;

namespace _08.TradeComissions
{
    class Program
    {
        static void Main(string[] args)
        {
            var town = Console.ReadLine().ToLower();
            var sales = double.Parse(Console.ReadLine());
            double comission = 0d;
            bool error = false;

            switch (town)
            {
                case "sofia":
                    if (sales >= 0 && sales <= 500)
                    {
                        comission = sales * 5 / 100;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        comission = sales * 7 / 100;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        comission = sales * 8 / 100;
                    }
                    else if (sales > 10000)
                    {
                        comission = sales * 12 / 100;
                    }
                    else
                    {
                        error = true;
                        Console.WriteLine("error");
                        break;
                    }
                    break;

                case "varna":
                    if (sales >= 0 && sales <= 500)
                    {
                        comission = sales * 4.5 / 100;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        comission = sales * 7.5 / 100;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        comission = sales * 10 / 100;
                    }
                    else if (sales > 10000)
                    {
                        comission = sales * 13 / 100;
                    }
                    else
                    {
                        error = true;
                        Console.WriteLine("error");
                        break;
                    }
                    break;

                case "plovdiv":
                    if (sales >= 0 && sales <= 500)
                    {
                        comission = sales * 5.5 / 100;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        comission = sales * 8 / 100;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        comission = sales * 12 / 100;
                    }
                    else if (sales > 10000)
                    {
                        comission = sales * 14.5 / 100;
                    }
                    else
                    {
                        error = true;
                        Console.WriteLine("error");
                        break;
                    }
                    break;

                default:
                    error = true;
                    Console.WriteLine("error");
                    break;
            }
            if (!error)
            {
                Console.WriteLine("{0:f2}", comission);
            }
        }
    }
}
