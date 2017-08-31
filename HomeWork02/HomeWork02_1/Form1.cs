using System;
using System.Windows.Forms;

namespace HomeWork02_1
{
    public partial class MainWindow : Form
    {
        private bool hasDotDigit = false;
        private double[] Temporary = new double[100];

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text == "0")
            {
                resultTextBox.Text = "1";
            }
            else
                resultTextBox.Text = resultTextBox.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text == "0")
            {
                resultTextBox.Text = "2";
            }
            else
                resultTextBox.Text = resultTextBox.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text == "0")
            {
                resultTextBox.Text = "3";
            }
            else
                resultTextBox.Text = resultTextBox.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text == "0")
            {
                resultTextBox.Text = "4";
            }
            else
                resultTextBox.Text = resultTextBox.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text == "0")
            {
                resultTextBox.Text = "5";
            }
            else
                resultTextBox.Text = resultTextBox.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text == "0")
            {
                resultTextBox.Text = "6";
            }
            else
                resultTextBox.Text = resultTextBox.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text == "0")
            {
                resultTextBox.Text = "7";
            }
            else
                resultTextBox.Text = resultTextBox.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text == "0")
            {
                resultTextBox.Text = "8";
            }
            else
                resultTextBox.Text = resultTextBox.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text == "0")
            {
                resultTextBox.Text = "9";
            }
            else
                resultTextBox.Text = resultTextBox.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text == "0")
            {
                resultTextBox.Text = "0";
            }
            else
                resultTextBox.Text = resultTextBox.Text + "0";
        }

        private void resultTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void dotButton_Click(object sender, EventArgs e)
        {
            if (!hasDotDigit)
            {
                resultTextBox.Text = resultTextBox.Text + ".";
                hasDotDigit = false;
            }
        }

        private void clearedButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = "";
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            double Temporary = double.Parse(resultTextBox.Text);
            resultTextBox.Text = "";
        }

        private void reduceButton_Click(object sender, EventArgs e)
        {
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
        }

        private void exceptButton_Click(object sender, EventArgs e)
        {
        }
    }
}