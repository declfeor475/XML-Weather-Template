using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            cityOutput.Text = Form1.days[0].location; // displays city

            // display days for the next 6 days
            dayOutput1.Text = DateTime.Now.AddDays(1).ToString("dddd");
            dayOutput2.Text = DateTime.Now.AddDays(2).ToString("dddd");
            dayOutput3.Text = DateTime.Now.AddDays(3).ToString("dddd");
            dayOutput4.Text = DateTime.Now.AddDays(4).ToString("dddd");
            dayOutput5.Text = DateTime.Now.AddDays(5).ToString("dddd");
            dayOutput6.Text = DateTime.Now.AddDays(6).ToString("dddd");

            // display min temps for the next 6 days
            minOutput1.Text = Convert.ToDouble(Form1.days[1].tempLow).ToString("0") + "°";
            minOutput2.Text = Convert.ToDouble(Form1.days[2].tempLow).ToString("0") + "°";
            minOutput3.Text = Convert.ToDouble(Form1.days[3].tempLow).ToString("0") + "°";
            minOutput4.Text = Convert.ToDouble(Form1.days[4].tempLow).ToString("0") + "°";
            minOutput5.Text = Convert.ToDouble(Form1.days[5].tempLow).ToString("0") + "°";
            minOutput6.Text = Convert.ToDouble(Form1.days[6].tempLow).ToString("0") + "°";

            // display max temps for the next 6 days
            maxOutput1.Text = Convert.ToDouble(Form1.days[1].tempHigh).ToString("0") + "°";
            maxOutput2.Text = Convert.ToDouble(Form1.days[2].tempHigh).ToString("0") + "°";
            maxOutput3.Text = Convert.ToDouble(Form1.days[3].tempHigh).ToString("0") + "°";
            maxOutput4.Text = Convert.ToDouble(Form1.days[4].tempHigh).ToString("0") + "°";
            maxOutput5.Text = Convert.ToDouble(Form1.days[5].tempHigh).ToString("0") + "°";
            maxOutput6.Text = Convert.ToDouble(Form1.days[6].tempHigh).ToString("0") + "°";

            // picture box for the first day changes depending on the conditions 
            if (Form1.days[1].condition.Contains("cloud"))
            {
                pictureBox1.BackgroundImage = Properties.Resources.Cloudy;
            }
            else if (Form1.days[1].condition.Contains("sun"))
            {
                pictureBox1.BackgroundImage = Properties.Resources.Sunny;
            }
            else if (Form1.days[1].condition.Contains("rain"))
            {
                pictureBox1.BackgroundImage = Properties.Resources.Rainy;
            }
            else if (Form1.days[1].condition.Contains("clear"))
            {
                pictureBox1.BackgroundImage = Properties.Resources.Clear;
            }
            else if (Form1.days[1].condition.Contains("fog"))
            {
                pictureBox1.BackgroundImage = Properties.Resources.Foggy;
            }
            else if (Form1.days[1].condition.Contains("snow"))
            {
                pictureBox1.BackgroundImage = Properties.Resources.Snowy;
            }

            // picture box for the second day changes depending on the conditions
            if (Form1.days[2].condition.Contains("cloud"))
            {
                pictureBox2.BackgroundImage = Properties.Resources.Cloudy;
            }
            else if (Form1.days[2].condition.Contains("sun"))
            {
                pictureBox2.BackgroundImage = Properties.Resources.Sunny;
            }
            else if (Form1.days[2].condition.Contains("rain"))
            {
                pictureBox2.BackgroundImage = Properties.Resources.Rainy;
            }
            else if (Form1.days[2].condition.Contains("clear"))
            {
                pictureBox2.BackgroundImage = Properties.Resources.Clear;
            }
            else if (Form1.days[2].condition.Contains("fog"))
            {
                pictureBox2.BackgroundImage = Properties.Resources.Foggy;
            }
            else if (Form1.days[2].condition.Contains("snow"))
            {
                pictureBox2.BackgroundImage = Properties.Resources.Snowy;
            }

            // picture box for the third day changes depending on the conditions
            if (Form1.days[3].condition.Contains("cloud"))
            {
                pictureBox3.BackgroundImage = Properties.Resources.Cloudy;
            }
            else if (Form1.days[3].condition.Contains("sun"))
            {
                pictureBox3.BackgroundImage = Properties.Resources.Sunny;
            }
            else if (Form1.days[3].condition.Contains("rain"))
            {
                pictureBox3.BackgroundImage = Properties.Resources.Rainy;
            }
            else if (Form1.days[3].condition.Contains("clear"))
            {
                pictureBox3.BackgroundImage = Properties.Resources.Clear;
            }
            else if (Form1.days[3].condition.Contains("fog"))
            {
                pictureBox3.BackgroundImage = Properties.Resources.Foggy;
            }
            else if (Form1.days[3].condition.Contains("snow"))
            {
                pictureBox3.BackgroundImage = Properties.Resources.Snowy;
            }

            // picture box for the fourth day changes depending on the conditions
            if (Form1.days[4].condition.Contains("cloud"))
            {
                pictureBox4.BackgroundImage = Properties.Resources.Cloudy;
            }
            else if (Form1.days[4].condition.Contains("sun"))
            {
                pictureBox4.BackgroundImage = Properties.Resources.Sunny;
            }
            else if (Form1.days[4].condition.Contains("rain"))
            {
                pictureBox4.BackgroundImage = Properties.Resources.Rainy;
            }
            else if (Form1.days[4].condition.Contains("clear"))
            {
                pictureBox4.BackgroundImage = Properties.Resources.Clear;
            }
            else if (Form1.days[4].condition.Contains("fog"))
            {
                pictureBox4.BackgroundImage = Properties.Resources.Foggy;
            }
            else if (Form1.days[4].condition.Contains("snow"))
            {
                pictureBox4.BackgroundImage = Properties.Resources.Snowy;
            }

            // picture box for the fifth day changes depending on the conditions
            if (Form1.days[5].condition.Contains("cloud"))
            {
                pictureBox5.BackgroundImage = Properties.Resources.Cloudy;
            }
            else if (Form1.days[5].condition.Contains("sun"))
            {
                pictureBox5.BackgroundImage = Properties.Resources.Sunny;
            }
            else if (Form1.days[5].condition.Contains("rain"))
            {
                pictureBox5.BackgroundImage = Properties.Resources.Rainy;
            }
            else if (Form1.days[5].condition.Contains("clear"))
            {
                pictureBox5.BackgroundImage = Properties.Resources.Clear;
            }
            else if (Form1.days[5].condition.Contains("fog"))
            {
                pictureBox5.BackgroundImage = Properties.Resources.Foggy;
            }
            else if (Form1.days[5].condition.Contains("snow"))
            {
                pictureBox5.BackgroundImage = Properties.Resources.Snowy;
            }

            // picture box for the sixth day changes depending on the conditions
            if (Form1.days[6].condition.Contains("cloud"))
            {
                pictureBox6.BackgroundImage = Properties.Resources.Cloudy;
            }
            else if (Form1.days[6].condition.Contains("sun"))
            {
                pictureBox6.BackgroundImage = Properties.Resources.Sunny;
            }
            else if (Form1.days[6].condition.Contains("rain"))
            {
                pictureBox6.BackgroundImage = Properties.Resources.Rainy;
            }
            else if (Form1.days[6].condition.Contains("clear"))
            {
                pictureBox6.BackgroundImage = Properties.Resources.Clear;
            }
            else if (Form1.days[6].condition.Contains("fog"))
            {
                pictureBox6.BackgroundImage = Properties.Resources.Foggy;
            }
            else if (Form1.days[6].condition.Contains("snow"))
            {
                pictureBox6.BackgroundImage = Properties.Resources.Snowy;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
    }
}
