using System;
using System.Windows.Forms;

namespace HomeWorkWindowsForms01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LabelCout.Text = string.Format("您所輸入的Pokemon資料\n" + "Pokemon編號：" + TextBoxid.Text + "\n" + "Pokemon名稱：" + TextBoxname.Text + "\n"
            + "Pokemon身高：" + TextBoxH.Text + " cm\n" + "Pokemon體重：" + TextBoxW.Text + " kg");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LabelCout.Text = "";
        }
    }
}