using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigherLower
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GAMES\nChoose a game you want to play\n1. Higher - Lower\n2. Heads/tails\n3. Quit program");

            int choice = int.Parse(Console.ReadLine());
            do
            {
                if (choice.Equals(1))
                {
                    char czy;
                    do
                    {
                        int guess = 0, rndNumber, i = 1;
                        Console.WriteLine("Welcome in the Higher - Lower game!\nYour goal is to guess a number from 1 to 50 randomly chosen by computer. You have 10 lifes.");
                        HigherLower game = new HigherLower();
                        rndNumber = game.random();
                        while (guess != rndNumber)
                        {
                            Console.WriteLine("Guess number: ");
                            guess = int.Parse(Console.ReadLine());
                            if (guess.Equals(rndNumber))
                            {
                                Console.WriteLine("Congratulations, you guessed the number in " + i + " try!"); break;
                            }
                            else
                            {
                                if (guess > rndNumber) Console.WriteLine("Lower!");
                                else Console.WriteLine("Higher!");
                            }
                            i++;
                            if (i.Equals(10))
                            {
                                Console.WriteLine("You didn't guess the number :(");
                                break;
                            }
                        }
                        Console.WriteLine("Do you want to try again? [Y/N]");
                        czy = Console.ReadKey().KeyChar;
                    } while (czy.Equals('n'));
                }
                else if (choice.Equals(2))
                {

                }
                else if (choice.Equals(3))
                {
                    System.Diagnostics.Process.GetCurrentProcess().Kill();
                }
                else
                {
                    Console.WriteLine("Wrong key");
                }
                Console.Read();
            } while (!(choice.Equals(3)));
            Console.Read();

        }

        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
    }
}
