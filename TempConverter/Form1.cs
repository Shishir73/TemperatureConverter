using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemperatureConverter;
using System.Xml;

namespace TempConverter
{
    public partial class Form1 : Form
    {
        Converter c = new Converter();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button_fahren_Click(object sender, EventArgs e)
        {
            double temp = double.Parse(textBox_input.Text);
           Output.Items.Add("F :" + c.temperatureToFahrenheit(temp));
        }
        private void button_celsius_Click(object sender, EventArgs e)
        {
            double temp = double.Parse(textBox_input.Text);
            Output.Items.Add("C :" + c.temperatureToCelsius(temp));
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlTextWriter xwriter = new XmlTextWriter("C:\\Users\\user\\source\\repos\\DNP1examn\\doc1.xml", Encoding.UTF8);
            xwriter.Formatting = Formatting.Indented;
            xwriter.WriteStartElement("temperatures");      //temperatures

            foreach (var item in Output.Items)
            {
                xwriter.WriteStartElement("temp");              //temp
                xwriter.WriteString(item.ToString());          //DATA
                xwriter.WriteEndElement();                      //</temp>
            }

            xwriter.WriteEndElement();                      //</temperatyres>
            xwriter.Close();
        }
    }
}
