using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemperatureConverter;

namespace TestTemperatureConverter
{
    class Program
    {

        static void Main(string[] args)
        {
            Converter tc = new Converter();

            Console.WriteLine("The temp is " + tc.temperatureToFahrenheit(20));

            Console.WriteLine(tc.temperatureToCelsius(32));

            Console.ReadKey();

        }
    }
}
