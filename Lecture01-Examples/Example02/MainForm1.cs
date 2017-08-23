using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example02
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = string.Format("Hello {0}" , nameTextBox.Text);
           // MessageBox.Show("Hello " + nameTextBox.Text);
        }

        private void MainForm1_Load(object sender, EventArgs e)
        {
            messageLabel.Text = "";
        }

        private void nameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            messageLabel.Text = string.Format("Hello {0}", nameTextBox.Text);
            nameTextBox.BackColor = SystemColors.Window;
        }

        private void MainForm1_KeyDown(object sender, KeyEventArgs e)
        {
            nameTextBox.BackColor = SystemColors.MenuHighlight;
        }

        private void nameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            nameTextBox.BackColor = SystemColors.MenuHighlight;
        }
    }
}
