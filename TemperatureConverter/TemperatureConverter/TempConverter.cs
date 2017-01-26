using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    class TempConverter
    {
        public double temperature;

        public void readTemp()
        {
            Console.WriteLine("Enter temperature: ");
            temperature = Convert.ToInt32(Console.ReadLine());
        }

        public double convertTempToF()
        {
            return (temperature * 9/5+32);
        }
        public double convertTempToC()
        {
            return (temperature - 32) * 5 / 9;
        }
    }

}
