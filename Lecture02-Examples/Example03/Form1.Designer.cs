namespace Example03
{
    partial class Form1
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
            this.number1TextBox = new System.Windows.Forms.TextBox();
            this.number2TextBox = new System.Windows.Forms.TextBox();
            this.addLabel = new System.Windows.Forms.Label();
            this.equalLabel = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.execButton = new System.Windows.Forms.Button();
            this.execAddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // number1TextBox
            // 
            this.number1TextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.number1TextBox.Location = new System.Drawing.Point(47, 41);
            this.number1TextBox.Name = "number1TextBox";
            this.number1TextBox.Size = new System.Drawing.Size(136, 39);
            this.number1TextBox.TabIndex = 0;
            // 
            // number2TextBox
            // 
            this.number2TextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.number2TextBox.Location = new System.Drawing.Point(252, 41);
            this.number2TextBox.Name = "number2TextBox";
            this.number2TextBox.Size = new System.Drawing.Size(144, 39);
            this.number2TextBox.TabIndex = 1;
            // 
            // addLabel
            // 
            this.addLabel.AutoSize = true;
            this.addLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addLabel.Location = new System.Drawing.Point(202, 45);
            this.addLabel.Name = "addLabel";
            this.addLabel.Size = new System.Drawing.Size(31, 30);
            this.addLabel.TabIndex = 2;
            this.addLabel.Text = "+";
            // 
            // equalLabel
            // 
            this.equalLabel.AutoSize = true;
            this.equalLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.equalLabel.Location = new System.Drawing.Point(419, 45);
            this.equalLabel.Name = "equalLabel";
            this.equalLabel.Size = new System.Drawing.Size(31, 30);
            this.equalLabel.TabIndex = 3;
            this.equalLabel.Text = "=";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resultTextBox.Location = new System.Drawing.Point(473, 41);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(144, 39);
            this.resultTextBox.TabIndex = 4;
            // 
            // execButton
            // 
            this.execButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.execButton.Location = new System.Drawing.Point(47, 103);
            this.execButton.Name = "execButton";
            this.execButton.Size = new System.Drawing.Size(570, 64);
            this.execButton.TabIndex = 5;
            this.execButton.Text = "執行加法";
            this.execButton.UseVisualStyleBackColor = true;
            this.execButton.Click += new System.EventHandler(this.execButton_Click);
            // 
            // execAddButton
            // 
            this.execAddButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.execAddButton.Location = new System.Drawing.Point(47, 203);
            this.execAddButton.Name = "execAddButton";
            this.execAddButton.Size = new System.Drawing.Size(570, 64);
            this.execAddButton.TabIndex = 6;
            this.execAddButton.Text = "執行真加法";
            this.execAddButton.UseVisualStyleBackColor = true;
            this.execAddButton.Click += new System.EventHandler(this.execAddButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 342);
            this.Controls.Add(this.execAddButton);
            this.Controls.Add(this.execButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.equalLabel);
            this.Controls.Add(this.addLabel);
            this.Controls.Add(this.number2TextBox);
            this.Controls.Add(this.number1TextBox);
            this.Name = "Form1";
            this.Text = "Example03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox number1TextBox;
        private System.Windows.Forms.TextBox number2TextBox;
        private System.Windows.Forms.Label addLabel;
        private System.Windows.Forms.Label equalLabel;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button execButton;
        private System.Windows.Forms.Button execAddButton;
    }
}

