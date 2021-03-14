using System;

namespace _4._2_Mod_Pract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write down your favourite color in English using small letters >");

            var color = Console.ReadLine();

            for (; ;)

                for (int i = 5; i <= 5; i--)

                {
                Console.WriteLine("Iteration > {0}", i);

                switch (Console.ReadLine())

                {
                    case "red":

                        Console.BackgroundColor = ConsoleColor.Red;

                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your fav color is red!");

                    break;

                    case "green":

                        Console.BackgroundColor = ConsoleColor.Green;

                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your fav color is green!");

                    break;

                    case "cyan":

                        Console.BackgroundColor = ConsoleColor.Cyan;

                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your fav color is cyan!");

                    break;

                    default:

                        Console.BackgroundColor = ConsoleColor.Yellow;

                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("You didn't pick up the color!");

                    break;
                }

                Console.ReadKey();
            }
        }
    }
 }