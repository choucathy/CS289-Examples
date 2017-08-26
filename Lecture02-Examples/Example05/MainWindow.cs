using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example05
{
    public partial class MainWindow : Form
    {
        private bool hasDotDigit = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = resultTextBox.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = resultTextBox.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {
        }

        private void button10_Click(object sender, EventArgs e)
        {
        }

        private void dotButton_Click(object sender, EventArgs e)
        {
            if (!hasDotDigit)
            {
                resultTextBox.Text = resultTextBox.Text + ".";
                hasDotDigit = true;
            }
        }
    }
}