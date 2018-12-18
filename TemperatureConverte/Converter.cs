using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemperatureConverter
{
    public class Converter
    {
        public int temperatureToCelsius(int fahrenheit)
        {
            int celsius;
            return celsius = (fahrenheit - 32) * 5 / 9;
        }

        public int temperatureToFahrenheit(int celsius)
        {
            int fahrenheit;
            return fahrenheit = (celsius * 9 / 5) + 32;
        }
    }
}
