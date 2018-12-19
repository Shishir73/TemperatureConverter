using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using TemperatureConverter;

namespace WebApplication
{
    /// <summary>
    /// Summary description for TemperatureWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TemperatureWebService : System.Web.Services.WebService
    {
        Converter c = new Converter();

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public double ConvertToFahrenheit(double celsius)
        {
            return c.temperatureToFahrenheit(celsius);
        }

        [WebMethod]
        public double ConvertToCelsius(double fahren)
        {
            return c.temperatureToCelsius(fahren);
        }
    }
}
