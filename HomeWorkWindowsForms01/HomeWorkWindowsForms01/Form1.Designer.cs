namespace HomeWorkWindowsForms01
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxid = new System.Windows.Forms.TextBox();
            this.TextBoxname = new System.Windows.Forms.TextBox();
            this.TextBoxH = new System.Windows.Forms.TextBox();
            this.TextBoxW = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LabelCout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(27, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "編號";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(27, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "名稱";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(27, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "身高";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(27, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "體重";
            // 
            // TextBoxid
            // 
            this.TextBoxid.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TextBoxid.Location = new System.Drawing.Point(127, 41);
            this.TextBoxid.Name = "TextBoxid";
            this.TextBoxid.Size = new System.Drawing.Size(220, 39);
            this.TextBoxid.TabIndex = 4;
            // 
            // TextBoxname
            // 
            this.TextBoxname.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TextBoxname.Location = new System.Drawing.Point(127, 96);
            this.TextBoxname.Name = "TextBoxname";
            this.TextBoxname.Size = new System.Drawing.Size(220, 39);
            this.TextBoxname.TabIndex = 5;
            // 
            // TextBoxH
            // 
            this.TextBoxH.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TextBoxH.Location = new System.Drawing.Point(127, 153);
            this.TextBoxH.Name = "TextBoxH";
            this.TextBoxH.Size = new System.Drawing.Size(220, 39);
            this.TextBoxH.TabIndex = 6;
            // 
            // TextBoxW
            // 
            this.TextBoxW.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TextBoxW.Location = new System.Drawing.Point(127, 212);
            this.TextBoxW.Name = "TextBoxW";
            this.TextBoxW.Size = new System.Drawing.Size(220, 39);
            this.TextBoxW.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(239, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 51);
            this.button1.TabIndex = 8;
            this.button1.Text = "輸入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LabelCout
            // 
            this.LabelCout.AutoSize = true;
            this.LabelCout.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LabelCout.Location = new System.Drawing.Point(428, 41);
            this.LabelCout.Name = "LabelCout";
            this.LabelCout.Size = new System.Drawing.Size(157, 30);
            this.LabelCout.TabIndex = 9;
            this.LabelCout.Text = "輸入資料內容";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 377);
            this.Controls.Add(this.LabelCout);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextBoxW);
            this.Controls.Add(this.TextBoxH);
            this.Controls.Add(this.TextBoxname);
            this.Controls.Add(this.TextBoxid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxid;
        private System.Windows.Forms.TextBox TextBoxname;
        private System.Windows.Forms.TextBox TextBoxH;
        private System.Windows.Forms.TextBox TextBoxW;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LabelCout;
    }
}

