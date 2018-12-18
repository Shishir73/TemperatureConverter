using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemperatureConverter
{
    public class Converter
    {
        public double temperatureToCelsius(double fahrenheit)
        {
            double celsius;
            return celsius = (fahrenheit - 32) * 5 / 9;
        }

        public double temperatureToFahrenheit(double celsius)
        {
            double fahrenheit;
            return fahrenheit = (celsius * 9 / 5) + 32;
        }
    }
}
