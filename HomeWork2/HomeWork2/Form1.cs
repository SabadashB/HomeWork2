using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeWork2Lib;

namespace HomeWork2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTask1_Click(object sender, EventArgs e)
        {
            textBoxTask1.Visible = true;
            int result = Homework2.Task1(Convert.ToInt32(numericUpDownTask1A.Value), Convert.ToInt32(numericUpDownTask1B.Value));
            textBoxTask1.Text = "Result = " + Convert.ToString(result);
        }

        private void buttonTask2_Click(object sender, EventArgs e)
        {
            textBoxTask2.Visible = true;
            double result = Homework2.Task2(Convert.ToDouble(numericUpDownTask2X.Value), Convert.ToDouble(numericUpDownTask2XY.Value));
            textBoxTask2.Text = "Coordinate quadrant: " + Convert.ToString(result);
        }

        private void buttonTask3_Click(object sender, EventArgs e)
        {
            textBoxTask3.Visible = true;
            int a = Convert.ToInt32(numericUpDownTask3A.Text);
            int b = Convert.ToInt32(numericUpDownTask3B.Text);
            int c = Convert.ToInt32(numericUpDownTask3C.Text);
            Homework2.Task3(ref a, ref b, ref c);
            textBoxTask3.Text = a.ToString() + " " + b.ToString() + " " + c.ToString();
        }

        private void buttonTask4_Click(object sender, EventArgs e)
        {
            textBoxTask4.Visible = true;
            (double? x1, double? x2) = Homework2.Task4(Convert.ToDouble(numericUpDownTask4A.Value),
    Convert.ToDouble(numericUpDownTask4B.Value),
    Convert.ToDouble(numericUpDownTask4C.Value));
            textBoxTask4.Text = "X1 = " + Convert.ToString(x1) + Environment.NewLine +
                "X2 = " + Convert.ToString(x2);
        }

        private void buttonTask5_Click(object sender, EventArgs e)
        {
            textBoxTask5.Visible = true;
            string result = Homework2.Task5(numericUpDownTask5.Value.ToString());
            textBoxTask5.Text = result;
        }
    }
}
