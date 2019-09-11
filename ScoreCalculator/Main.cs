using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreCalculator
{
	public partial class Main : Form
	{
		private int totalNum = 0;
		private int correctNum = 0;
		private int X = 0;
		private double average = 0;

		public Main()
		{
			InitializeComponent();
		}

		private void NumericUpDownTotal_ValueChanged(object sender, EventArgs e)
		{
			totalNum = Convert.ToInt32(numericUpDownTotal.Value);
			textBoxTotal.Text = totalNum.ToString();

			Calculate();
		}

		private void NumericUpDownCorrect_ValueChanged(object sender, EventArgs e)
		{
			correctNum = Convert.ToInt32(numericUpDownCorrect.Value);
			textBoxO.Text = correctNum.ToString();

			Calculate();
		}

		private void NumericUpDownTotal_KeyUp(object sender, KeyEventArgs e)
		{
			NumericUpDownTotal_ValueChanged(sender, e);
		}

		private void NumericUpDownCorrect_KeyUp(object sender, KeyEventArgs e)
		{
			NumericUpDownCorrect_ValueChanged(sender, e);
		}

		private void Calculate()
		{
			if (totalNum == 0 && correctNum == 0)
			{
				// TODO
			}

			else if (totalNum == 0 && correctNum != 0)
			{
				// TODO
			}

			else if (totalNum < correctNum)
			{
				numericUpDownCorrect.Value = totalNum;
				textBoxO.Text = totalNum.ToString();
			}

			else
			{
				X = totalNum - correctNum;
				average = Math.Round(Convert.ToDouble(correctNum) / Convert.ToDouble(totalNum) * 100, 2);

				textBoxX.Text = X.ToString();
				textBoxAvg.Text = average.ToString() + "%";
			}
		}
	}
}
