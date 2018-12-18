using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    public class Converter
    {
        public void temperatureToCelsius(int fahrenheit)
        {
            int celsius = (fahrenheit - 32) * 5 / 9;
        }

        public void temperatureToFahrenheit(int celsius)
        {
            int fahrenheit = (celsius  * 5 / 9) + 32;
        }
    }
}
