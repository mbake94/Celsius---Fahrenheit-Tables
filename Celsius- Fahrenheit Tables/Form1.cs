using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
			string celsius;
			lowCelsius = Double.Parse(txtLowTemp.Text);
			highCelsius = Double.Parse(txtHighTemp.Text);
			increments = Double.Parse(txtIncrement.Text);
			fahrenheit = (1.8 * lowCelsius) + 32;
 
			for (double i = lowCelsius; i <= highCelsius; increments++)
			{

				celsius = lowCelsius.PadRight(15); 
				celsius &= fahrenheit.Parce("C2").PadLeft(5);
				lstConverter.Items.Add(celsius);

			}
		}
	}
}
