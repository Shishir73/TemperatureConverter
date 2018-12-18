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
            double[] temperatures = { 60.0, 68.4, 72.2, 80.1, 20.8, 12.2 };

            Converter tc = new Converter();

            Console.WriteLine("The temp is " + tc.temperatureToFahrenheit(20));

            Console.WriteLine(tc.temperatureToCelsius(32));

            for(int i = 0; i < temperatures.Length; i++)
            {
                Console.Write(tc.temperatureToFahrenheit(temperatures[i]) + " ");
            }


            Console.ReadKey();
        }
    }
}
