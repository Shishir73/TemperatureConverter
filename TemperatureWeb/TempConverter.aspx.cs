using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication;

namespace TemperatureWeb
{
    public partial class TempConverter : System.Web.UI.Page
    {
        TemperatureWebService ts = new TemperatureWebService();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Celsius_Click(object sender, EventArgs e)
        {

            var data1 = ts.ConvertToCelsius(double.Parse(TextBox_input.Text));
            Label_output.Text = data1.ToString();
        }

        protected void Button_Fahren_Click(object sender, EventArgs e)
        {
            var data2 = ts.ConvertToFahrenheit(double.Parse(TextBox_input.Text));
            Label_output.Text = data2.ToString();
        }
    }
}