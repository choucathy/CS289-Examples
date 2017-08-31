namespace HomeWork02_1
{
    partial class MainWindow
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.dotButton = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.reduceButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.exceptButton = new System.Windows.Forms.Button();
            this.clearedButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultTextBox
            // 
            this.resultTextBox.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resultTextBox.Location = new System.Drawing.Point(27, 48);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(313, 66);
            this.resultTextBox.TabIndex = 0;
            this.resultTextBox.TextChanged += new System.EventHandler(this.resultTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 78);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 78);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(252, 140);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 78);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(27, 241);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 78);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(138, 241);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 78);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(252, 241);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(88, 78);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(27, 340);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(88, 78);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(138, 340);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(88, 78);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(252, 340);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(88, 78);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(138, 433);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(88, 78);
            this.button0.TabIndex = 10;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // dotButton
            // 
            this.dotButton.Location = new System.Drawing.Point(27, 433);
            this.dotButton.Name = "dotButton";
            this.dotButton.Size = new System.Drawing.Size(88, 78);
            this.dotButton.TabIndex = 11;
            this.dotButton.Text = ".";
            this.dotButton.UseVisualStyleBackColor = true;
            this.dotButton.Click += new System.EventHandler(this.dotButton_Click);
            // 
            // equalButton
            // 
            this.equalButton.Location = new System.Drawing.Point(252, 433);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(88, 78);
            this.equalButton.TabIndex = 12;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = true;
            this.equalButton.Click += new System.EventHandler(this.equalButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(366, 140);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(88, 78);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // reduceButton
            // 
            this.reduceButton.Location = new System.Drawing.Point(366, 241);
            this.reduceButton.Name = "reduceButton";
            this.reduceButton.Size = new System.Drawing.Size(88, 78);
            this.reduceButton.TabIndex = 14;
            this.reduceButton.Text = "-";
            this.reduceButton.UseVisualStyleBackColor = true;
            this.reduceButton.Click += new System.EventHandler(this.reduceButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Location = new System.Drawing.Point(366, 340);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(88, 78);
            this.multiplyButton.TabIndex = 15;
            this.multiplyButton.Text = "x";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // exceptButton
            // 
            this.exceptButton.Location = new System.Drawing.Point(366, 433);
            this.exceptButton.Name = "exceptButton";
            this.exceptButton.Size = new System.Drawing.Size(88, 78);
            this.exceptButton.TabIndex = 16;
            this.exceptButton.Text = "/";
            this.exceptButton.UseVisualStyleBackColor = true;
            this.exceptButton.Click += new System.EventHandler(this.exceptButton_Click);
            // 
            // clearedButton
            // 
            this.clearedButton.Location = new System.Drawing.Point(366, 42);
            this.clearedButton.Name = "clearedButton";
            this.clearedButton.Size = new System.Drawing.Size(88, 78);
            this.clearedButton.TabIndex = 17;
            this.clearedButton.Text = "C";
            this.clearedButton.UseVisualStyleBackColor = true;
            this.clearedButton.Click += new System.EventHandler(this.clearedButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 530);
            this.Controls.Add(this.clearedButton);
            this.Controls.Add(this.exceptButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.reduceButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.dotButton);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultTextBox);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button dotButton;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button reduceButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button exceptButton;
        private System.Windows.Forms.Button clearedButton;
    }
}

