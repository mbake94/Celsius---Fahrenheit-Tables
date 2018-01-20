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
			double celsius, lowCelsius, highCelsius, fahrenheit; /*xyz*/
			double increments;
			lowCelsius = Double.Parse(txtLowTemp.Text);
			highCelsius = Double.Parse(txtHighTemp.Text);
			increments = Double.Parse(txtIncrement.Text);
			//xyz = lowCelsius + increments; 

			for (double i = lowCelsius; i <= highCelsius; increments++);
			{

			}
			/*if (lowCelsius < highCelsius)
			{
				
			}*/


		}
	}
}
