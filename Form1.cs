using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHS
{
	public partial class Form1 : Form
	{
		ComplexNum A, B, C, D, X;

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			A = new ComplexNum((float)numericUpDown1.Value, (float)numericUpDown2.Value, (int)numericUpDown9.Value);
			textBox1.Text = A.getCN();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			B = new ComplexNum((float)numericUpDown3.Value, (float)numericUpDown4.Value, (int)numericUpDown10.Value);
			textBox1.Text = B.getCN();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			C = new ComplexNum((float)numericUpDown5.Value, (float)numericUpDown6.Value, (int)numericUpDown11.Value);
			textBox1.Text = C.getCN();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			D = new ComplexNum((float)numericUpDown7.Value, (float)numericUpDown8.Value, (int)numericUpDown12.Value);
			textBox1.Text = D.getCN();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			A = new ComplexNum((float)numericUpDown1.Value, (float)numericUpDown2.Value, (int)numericUpDown9.Value);
			B = new ComplexNum((float)numericUpDown3.Value, (float)numericUpDown4.Value, (int)numericUpDown10.Value);
			C = new ComplexNum((float)numericUpDown5.Value, (float)numericUpDown6.Value, (int)numericUpDown11.Value);
			D = new ComplexNum((float)numericUpDown7.Value, (float)numericUpDown8.Value, (int)numericUpDown12.Value);

			X = ((A + B) * C * C) / (B - A);

			textBox1.Text = X.getCN();
		}
	}
}
