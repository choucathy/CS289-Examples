using System;
using System.Windows.Forms;

namespace HomeWorkWindowsForms01
{
    public partial class loadForm : Form
    {
        public loadForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            outLabel.Text = "";
        }

        private void startButton_Click_1(object sender, EventArgs e)
        {
            outLabel.Text = string.Format("您所輸入的Pokemon資料\n" + "Pokemon編號：" + idTextBox.Text + "\n" + "Pokemon名稱：" + nameTextBox.Text + "\n"
                        + "Pokemon身高：" + hTextBox.Text + " cm\n" + "Pokemon體重：" + wTextBox.Text + " kg");
        }
    }
}