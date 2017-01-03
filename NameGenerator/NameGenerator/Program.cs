using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            char genderChosen;
            Console.WriteLine("NAME GENERATOR");
            Console.WriteLine("Select your gender.\nPress:\n1. 'm' for male\n2. 'f' for female\n3. 'q' to quit program\n");

            do
            {
                genderChosen = Console.ReadKey().KeyChar; // wczytywanie znaku od uzytkownika do zmiennej
                if (!(genderChosen.Equals('f') || genderChosen.Equals('m') || genderChosen.Equals('q')))
                {
                    ClearCurrentConsoleLine();
                    Console.Write("You pressed a wrong char, try again");
                    System.Threading.Thread.Sleep(1000); // zatrzymanie dzialania na 1 sek
                    ClearCurrentConsoleLine();
                }
                else if ((genderChosen.Equals('f') || genderChosen.Equals('m')))
                {
                    ClearCurrentConsoleLine();
                    Generator gen = new Generator();
                    gen.generate(genderChosen);
                }
                else if (genderChosen.Equals('q'))
                {
                    System.Diagnostics.Process.GetCurrentProcess().Kill(); // wylaczanie aplikacji
                }
            } while (!(genderChosen.Equals('q')));
        }

        // clear current line
        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }

    }
}
