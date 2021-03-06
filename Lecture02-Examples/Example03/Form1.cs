﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void execButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = number1TextBox.Text + number2TextBox.Text;
        }

        private void execAddButton_Click(object sender, EventArgs e)
        {
            //resultTextBox.Text = (333333).ToString();  //變數.tostring();

            int number1 = 0;
            bool succes = int.TryParse(number1TextBox.Text, out number1);  //int.TryParse(string s , out 變數);
            if (!succes)  //如果不成功
            {
                MessageBox.Show("number1 輸入錯誤，請重新輸入"); //跳出訊息方塊
                return;  //結束 後面的程式不執行
            }

            int number2 = 0;
            succes = int.TryParse(number2TextBox.Text, out number2);  //int.TryParse(string s , out 變數);
            if (!succes)  //如果不成功
            {
                MessageBox.Show("number2 輸入錯誤，請重新輸入"); //跳出訊息方塊
                return;  //結束 後面的程式不執行
            }

            resultTextBox.Text = (number1 + number2).ToString();
        }
    }
}