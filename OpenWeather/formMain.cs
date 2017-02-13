using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace OpenWeather
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();

            listShowWeather.Columns.Add("Date and hour", 160);
            listShowWeather.Columns.Add("Temperature", 100);
            listShowWeather.Columns.Add("Humidity level", 100);
            listShowWeather.Columns.Add("Wind speed", 100);
            listShowWeather.Columns.Add("Clouds", 100);
            listShowWeather.Columns.Add("Weather", 120);

            listShowWeather.View = View.Details;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxCities.Text != "")
            {
                listShowWeather.Items.Clear();
                string[] items = new string[6];

                WebClient client = new WebClient();
                client.Encoding = Encoding.UTF8;
                string address = client.DownloadString("http://api.openweathermap.org/data/2.5/forecast?q=" + textBoxCities.Text + "&mode=xml&lang=fr&appid=4c751f95a60360ae52bee41672463b92");

                XmlDocument xmlclient = new XmlDocument();
                xmlclient.LoadXml(address);

                XmlNodeList nodes = xmlclient.DocumentElement.SelectNodes("//weatherdata/forecast/time");

                foreach (XmlNode node in nodes)
                {
                    string from = node.Attributes["from"].Value;
                    string to = node.Attributes["to"].Value;

                    string[] startTime = from.Split('T');
                    string[] endTime = to.Split('T');

                    string dateAndHour = from.Substring(0, 10) + " " + startTime[1] + "-" + endTime[1];

                    if(startTime[1] == "00:00:00" || startTime[1] == "03:00:00" || endTime[1] == "00:00:00")
                    {

                    }
                    else
                    {
                        items[0] = dateAndHour;

                        foreach(XmlNode properties in node.ChildNodes)
                        {
                            switch (properties.Name)
                            {
                                case "temperature":
                                    items[1] = properties.Attributes["value"].Value + " °C";
                                    break;
                                case "humidity":
                                    items[2] = properties.Attributes["value"].Value + " " + properties.Attributes["unit"].Value;
                                    break;
                                case "windSpeed":
                                    items[3] = properties.Attributes["mps"].Value + " mps";
                                    break;
                                case "clouds":
                                    items[4] = properties.Attributes["value"].Value;
                                    break;
                                case "symbol":
                                    items[5] = properties.Attributes["name"].Value;
                                    break;
                            }
                        }

                        ListViewItem lv = new ListViewItem(items);
                        listShowWeather.Items.Add(lv);
                    }
                }
            }
        }
    }
}
