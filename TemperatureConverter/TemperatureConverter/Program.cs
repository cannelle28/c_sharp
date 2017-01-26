using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            TempConverter converter = new TempConverter();

            Console.WriteLine("TEMPERATURE CONVERTER\n");
            Console.WriteLine("1. Celsius -> Fahrenheit\n2. Fahrenheit -> Celsius\n");
            do
            {
                choice = Convert.ToInt32(Console.ReadLine());
                if (!(choice.Equals(1) || choice.Equals(2))) Console.WriteLine("Wrog input");
            } while (!(choice.Equals(1) || choice.Equals(2)));

            if (choice.Equals(1))
            {
                converter.readTemp();
                Console.WriteLine(converter.convertTempToF() + " F");
            }
            else
            {
                converter.readTemp();
                Console.WriteLine(converter.convertTempToC() + " C");
            }

            Console.Read();
        }
    }
}
