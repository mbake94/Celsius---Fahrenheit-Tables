using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Celsius__Fahrenheit_Tables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            double lowCelsius, highCelsius, fahrenheit;
            double increments;
            string celsius = "";
            lowCelsius = Double.Parse(txtLowTemp.Text);
            highCelsius = Double.Parse(txtHighTemp.Text);
            increments = Double.Parse(txtIncrement.Text);
            List<string> list = new List<string>();

            for (double i = lowCelsius; i <= highCelsius; i+=increments)
            {
                fahrenheit = (1.8 * i) + 32;
                celsius = "\t" + i + "\t\t" + fahrenheit;
                list.Add(celsius);
                lstConverter.Items.Add(list[list.Count-1]);


            }
            

        }

        private void lstConverter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
