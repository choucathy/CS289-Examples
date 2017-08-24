namespace HomeWorkWindowsForms01
{
    partial class loadForm
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
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.hLabel = new System.Windows.Forms.Label();
            this.wLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.hTextBox = new System.Windows.Forms.TextBox();
            this.wTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.outLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.idLabel.Location = new System.Drawing.Point(27, 45);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(61, 30);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "編號";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nameLabel.Location = new System.Drawing.Point(27, 100);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(61, 30);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "名稱";
            // 
            // hLabel
            // 
            this.hLabel.AutoSize = true;
            this.hLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.hLabel.Location = new System.Drawing.Point(27, 157);
            this.hLabel.Name = "hLabel";
            this.hLabel.Size = new System.Drawing.Size(61, 30);
            this.hLabel.TabIndex = 2;
            this.hLabel.Text = "身高";
            // 
            // wLabel
            // 
            this.wLabel.AutoSize = true;
            this.wLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.wLabel.Location = new System.Drawing.Point(27, 216);
            this.wLabel.Name = "wLabel";
            this.wLabel.Size = new System.Drawing.Size(61, 30);
            this.wLabel.TabIndex = 3;
            this.wLabel.Text = "體重";
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.idTextBox.Location = new System.Drawing.Point(127, 41);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(220, 39);
            this.idTextBox.TabIndex = 4;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nameTextBox.Location = new System.Drawing.Point(127, 96);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(220, 39);
            this.nameTextBox.TabIndex = 5;
            // 
            // hTextBox
            // 
            this.hTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.hTextBox.Location = new System.Drawing.Point(127, 153);
            this.hTextBox.Name = "hTextBox";
            this.hTextBox.Size = new System.Drawing.Size(220, 39);
            this.hTextBox.TabIndex = 6;
            // 
            // wTextBox
            // 
            this.wTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.wTextBox.Location = new System.Drawing.Point(127, 212);
            this.wTextBox.Name = "wTextBox";
            this.wTextBox.Size = new System.Drawing.Size(220, 39);
            this.wTextBox.TabIndex = 7;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.startButton.Location = new System.Drawing.Point(239, 287);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(108, 51);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "輸入";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click_1);
            // 
            // outLabel
            // 
            this.outLabel.AutoSize = true;
            this.outLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.outLabel.Location = new System.Drawing.Point(428, 41);
            this.outLabel.Name = "outLabel";
            this.outLabel.Size = new System.Drawing.Size(109, 30);
            this.outLabel.TabIndex = 9;
            this.outLabel.Text = "資料內容";
            // 
            // loadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 377);
            this.Controls.Add(this.outLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.wTextBox);
            this.Controls.Add(this.hTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.wLabel);
            this.Controls.Add(this.hLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idLabel);
            this.Name = "loadForm";
            this.Text = "神奇寶貝";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label hLabel;
        private System.Windows.Forms.Label wLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox hTextBox;
        private System.Windows.Forms.TextBox wTextBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label outLabel;
    }
}

