using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XMLWeather.Properties;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            dateLabel.Text = DateTime.Now.ToString("dddd" + ", " + "MMMM" + " dd"); // displays current day 

            cityOutput.Text = Form1.days[0].location; // displays city

            tempLabel.Text = Math.Round(Convert.ToDouble(Form1.days[0].currentTemp), 0) + "°C"; // displays current temperature
            minOutput.Text = Math.Round(Convert.ToDouble(Form1.days[0].tempLow), 0) + "°"; // displays minimum temperature for current day
            maxOutput.Text = Math.Round(Convert.ToDouble(Form1.days[0].tempHigh), 0) + "°"; // displays maximum temperature for current day

            sunriseOutput.Text = Convert.ToDateTime(Form1.days[0].sunrise).ToString("hh:mm tt"); // displays sunrise time for current day
            sunsetOutput.Text = Convert.ToDateTime(Form1.days[0].sunset).ToString("hh:mm tt"); // displays sunset time for current day

            // background changes depending on the current conditions
            if (Form1.days[0].condition.Contains("cloud"))
            {
                this.BackgroundImage = Properties.Resources.Cloudy;
            }
            else if (Form1.days[0].condition.Contains("sun"))
            {
                this.BackgroundImage = Properties.Resources.Sunny;
            }
            else if (Form1.days[0].condition.Contains("rain"))
            {
                this.BackgroundImage = Properties.Resources.Rainy;
            }
            else if (Form1.days[0].condition.Contains("clear"))
            {
                this.BackgroundImage = Properties.Resources.Clear;
            }
            else if (Form1.days[0].condition.Contains("fog"))
            {
                this.BackgroundImage = Properties.Resources.Foggy;
            }
            else if (Form1.days[0].condition.Contains("snow"))
            {
                this.BackgroundImage = Properties.Resources.Snowy;
            }
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }
    }
}
